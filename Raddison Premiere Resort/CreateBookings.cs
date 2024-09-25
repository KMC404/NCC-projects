using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace Raddison_Premiere_Resort
{
    // making the objects serializable
    [Serializable()]
    public class CreateBookings :  ISerializable
    {
        public string name
        {
            get; set;
        }

        public string phonenumber
        {
            get; set;
        }

        public string address
        {
            get; set;
        }

        public string duration
        {
            get; set;
        }

        internal void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        public bool standard
        {
            get; set;
        }

        public bool premium
        {
            get; set;
        }

        public bool executive
        {
            get; set;
        }

        public CreateBookings(SerializationInfo info, StreamingContext context) // for constructing deserialized objects out of a file...
        {
            name = (string)info.GetValue("NAME", typeof(string));
            phonenumber = (string)info.GetValue("PHONE NUMBER", typeof(string));
            address = (string)info.GetValue("ADDRESS", typeof(string));
            duration = (string)info.GetValue("DURATION", typeof(string));
            standard = ((bool)info.GetValue(Convert.ToString(true), typeof(bool)));
            premium = ((bool)info.GetValue(Convert.ToString(true), typeof(bool)));
            executive = ((bool)info.GetValue(Convert.ToString(true), typeof(bool)));
        }


        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)  // for serializing objects into a stream of bytes for file storage..
        {                                                                                    // this may be overridden later for different types of users...
            info.AddValue("NAME", name);
            info.AddValue("PHONE NUMBER", phonenumber);
            info.AddValue("ADDRESS", address);
            info.AddValue("DURATION", duration);
            info.AddValue(Convert.ToString(true), standard || premium || executive);
        }
        public CreateBookings() { }
    }
}
