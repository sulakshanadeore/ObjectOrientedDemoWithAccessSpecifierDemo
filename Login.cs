using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Login
    {
        //Fully implemented property
        //string _username;
        //public string Username 
        //{ 
        //    get 
        //    { 
        //        return _username; 
        //    } 
        //    set 
        //    {
        //        _username = value; 
        //    } 
        //}

        public string UserName { get; set; }
        //Automatic Properties/Auto(matically) implemented property
        public string Password { get; set; }

        public bool ValidateCredentials()
        {

            bool isValidUser = false;
            if (UserName=="Gauri" && Password=="Gauri@123")
            {
                isValidUser = true;
            }
        return isValidUser; 
        }

        //Read only property
        bool _isSuccess = false;
        public bool IsLoginSuccessful
        {
            get
            {
                return _isSuccess;
            }
            private set
            {
                _isSuccess = value;
            }
        }


        //Read only property
        int _otp = 123;
        public int OTP
        {
            //read the value
            get { return _otp; }

        }



        //Write only property
        int _validateOTP;
        public int CheckOTP
        {
            set
            {
                _validateOTP = value;

                if (_otp == _validateOTP)
                {
                    
                    IsLoginSuccessful = true;

                }

            }

        }
    }
}

