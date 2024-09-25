using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Raddison_Premiere_Resort
{
    [Serializable()]
    class Accounts : ISerializable
    {
        private List<Accounts> accounts;
        // declaring variables
        public string realname;
        public string password;
        public bool admin;
       

        public Accounts(string realname, string password, bool admin)
        {
            this.realname = realname;
            this.password = password;
            this.admin = admin;
        }

        public Accounts()
        {
        }

        public Accounts(string realname, string password)
        {
            this.realname = realname;
            this.password = password;
        }

        // password validation

        public virtual Boolean checkPassword(string Pass)
        {
            if (Pass.ToLower().Equals(password.ToLower()))
            {
                return true;
            }
            return false;
        }



        public string Realname
        {
            get { return realname; }
            set { realname = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }


        public Accounts(SerializationInfo info, StreamingContext context)
        {
            Realname = (String)info.GetValue("Username", typeof(String));
            password = (String)info.GetValue("password", typeof(String));
            admin = (bool)info.GetValue("Admin", typeof(bool));


        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Username", Realname);
            info.AddValue("password", password);
            info.AddValue("Admin?", admin);

        }


        public void saveData()
        {
            Stream output;
            BinaryFormatter bf = new BinaryFormatter();
            output = File.Open("Accounts", FileMode.Create);
            bf.Serialize(output, accounts);
            output.Close();
        }

        public void loadData()
        {
            Stream output;
            BinaryFormatter bf = new BinaryFormatter();
            output = File.Open("Acconuts", FileMode.Open);
            if (output.Length != 0)
            {
                accounts = (List<Accounts>)bf.Deserialize(output);
            }
            output.Close();

        }



    }

}
