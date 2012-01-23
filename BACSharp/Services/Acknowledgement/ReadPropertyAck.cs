﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BACSharp.APDU;
using BACSharp.Types;

namespace BACSharp.Services.Acknowledgement
{
    public class ReadPropertyAck : IBacNetApdu
    {
        public BacNetObject Obj { get; set; }
        public byte InvokeId { get; set; }

        public ReadPropertyAck(byte[] apdu)
        {
            InvokeId = apdu[1];
            int len = 3;
            //Object tag
            BacNetTag objectIdTag = new BacNetTag(apdu, len, ref len);
            if (objectIdTag.Class == false)
                throw new Exception("Reject.Invalid_tag");
            Obj = new BacNetObject(apdu, len, ref len);
            //Property Id
            BacNetTag propertyIdTag = new BacNetTag(apdu, len, ref len);
            if (propertyIdTag.Number != 1)
                throw new Exception("Reject.Invalid_tag");
            BacNetUInt PropertyId = new BacNetUInt(apdu, len, propertyIdTag.Length, ref len);
            BacNetTag openingTag = new BacNetTag(apdu, len, ref len);
            ArrayList ValueList = new ArrayList();
            if (openingTag.Length == 6)
            {                
                BacNetTag metaTag = new BacNetTag(apdu, len, ref len);
                while (metaTag.Length != 7)
                {
                    object value = ByteConverter.GetAppTagValue(apdu, len, metaTag, ref len);
                    ValueList.Add(value);
                    metaTag = new BacNetTag(apdu, len, ref len);
                }
            }
            BacNetProperty property = new BacNetProperty {PropertyId = PropertyId, Values = ValueList};
            Obj.Properties.Add(property);
        }


        /// <summary>
        /// todo: реализовать выбор свойства для отправки
        /// </summary>
        /// <returns></returns>
        public byte[] GetBytes()
        {
            ArrayList res = new ArrayList();

            res.Add((byte)BacNetEnums.BACNET_PDU_TYPE.PDU_TYPE_COMPLEX_ACK);
            res.Add(InvokeId);
            res.Add((byte)BacNetEnums.BACNET_CONFIRMED_SERVICE.SERVICE_CONFIRMED_READ_PROPERTY);

            //Object ID
            BacNetTag objectTag = new BacNetTag { Class = true, Length = 4, Number = 0 };
            res.AddRange(objectTag.GetBytes());
            res.AddRange(Obj.GetObjectBytes());

            //Max APDU
            BacNetTag propertyIdTag = new BacNetTag { Class = true, Length = (byte)Obj.Properties[0].PropertyId.GetLength(), Number = 1 };
            res.AddRange(propertyIdTag.GetBytes());
            res.AddRange(Obj.Properties[0].PropertyId.GetBytes());

            /*if (ArrayIndex != null)
            {
                BacNetTag arrayIndexTag = new BacNetTag { Class = true, Length = (byte)ArrayIndex.GetLength(), Number = 2 };
                res.AddRange(arrayIndexTag.GetBytes());
                res.AddRange(ArrayIndex.GetBytes());
            }*/

            return (byte[])res.ToArray(typeof(byte));
        }
    }
}