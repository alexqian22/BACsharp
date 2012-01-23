﻿using System;
using System.Collections;
using System.Linq;
using System.Net;
using BACSharp.NPDU;
using BACSharp.Services.Acknowledgement;
using BACSharp.Services.Confirmed;
using BACSharp.Services.Unconfirmed;
using BACSharp.Types;

namespace BACSharp
{
    public class BacNetResponse
    {
        public BacNetResponse()
        {    
        }

        #region Unconfirmed

        public void ReceivedIAm(BacNetRawMessage msg, IPEndPoint endPoint)
        {
            BacNetRemoteDevice newDevice = new BacNetRemoteDevice();
            newDevice.EndPoint = endPoint;
            BacNetIpNpdu npdu = new BacNetIpNpdu(msg.Npdu);
            IAm apdu = new IAm(msg.Apdu);
            if (npdu.Source != null)
                newDevice.BacAddress = npdu.Source;
            newDevice.MaxApduLength = apdu.MaxApduLength;
            newDevice.InstanceNumber = apdu.deviceObject.ObjectId;            
            newDevice.Segmentation = apdu.SegmentationSupported;
            newDevice.VendorId = apdu.VendorId;

            if (newDevice.InstanceNumber == BacNetDevice.Instance.DeviceId)
                return;

            BacNetRemoteDevice rem =
                BacNetDevice.Instance.Remote.FirstOrDefault(s => s.InstanceNumber == newDevice.InstanceNumber);
            if (rem != null)
                BacNetDevice.Instance.Remote.Remove(rem);

            BacNetDevice.Instance.Remote.Add(newDevice);
        }

        public void ReceivedIHave(BacNetRawMessage msg)
        {
            //todo: implement method
        }

        public void ReceivedCovNotification(BacNetRawMessage msg)
        {
            //todo: implement method
        }

        public void ReceivedEventNotification(BacNetRawMessage msg)
        {
            //todo: implement method
        }

        public void ReceivedPrivateTransfer(BacNetRawMessage msg)
        {
            //todo: implement method
        }

        public void ReceivedTextMessage(BacNetRawMessage msg)
        {
            //todo: implement method
        }

        public void ReceivedTimeSynchronization(BacNetRawMessage msg)
        {
            //todo: implement method
        }


        public void ReceivedWhoHas(BacNetRawMessage msg)
        {
            //todo: implement method
        }

        public void ReceivedWhoIs(BacNetRawMessage msg)
        {
            WhoIs apdu = new WhoIs(msg.Apdu);
            uint devId = BacNetDevice.Instance.DeviceId;
            if ((apdu.LowLimit != null && apdu.HighLimit != null && apdu.LowLimit.Value < devId && apdu.HighLimit.Value > devId) || (apdu.LowLimit == null || apdu.HighLimit == null))
                BacNetDevice.Instance.Services.Unconfirmed.IAm();
        }

        public void ReceivedUtcTimeSynchronization(BacNetRawMessage msg)
        {
            //todo: implement method
        }


        #endregion

        #region Confirmed

        public void ReceivedReadProperty(BacNetRawMessage msg)
        {
            try
            {
                ReadProperty apdu = new ReadProperty(msg.Apdu);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Reject.Missing_required_paramter")
                {
                    //Отправляем сообщение об ошибке
                }
                throw;
            }            
        }

        #endregion

        #region Acknowledgement

        public void ReceivedReadPropertyAck(BacNetRawMessage msg)
        {
            ReadPropertyAck apdu = new ReadPropertyAck(msg.Apdu);
            if (BacNetDevice.Instance.Waiter is int && Convert.ToInt32(BacNetDevice.Instance.Waiter) == apdu.InvokeId)
                BacNetDevice.Instance.Waiter = apdu.Obj.Properties[0].Values;
        }

        public void ReceivedReadPropertyMultipleAck(BacNetRawMessage msg)
        {
            ReadPropertyMultipleAck apdu = new ReadPropertyMultipleAck(msg.Apdu);
            if (BacNetDevice.Instance.Waiter is int && Convert.ToInt32(BacNetDevice.Instance.Waiter) == apdu.InvokeId)
                BacNetDevice.Instance.Waiter = apdu.ObjectList;
        }

        public void ReceivedErrorAck(BacNetRawMessage msg)
        {
            ErrorAck apdu = new ErrorAck(msg.Apdu);
            ArrayList res = new ArrayList();
            res.Add(apdu.ErrorCode);
            if (BacNetDevice.Instance.Waiter is int && Convert.ToInt32(BacNetDevice.Instance.Waiter) == apdu.InvokeId)
                BacNetDevice.Instance.Waiter = res;
        }

        #endregion
    }
}