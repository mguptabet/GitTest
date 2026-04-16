using System;

namespace Telephone
{
    public class KeypadPhone
    {
        public string sim;
        public string _brand;
        public string _model;

        // Constructor
        public KeypadPhone(string model, string brand)
        {
            _model = model;
            _brand = brand;
        }

        // Call Method
        public void call(string mobileNo)
        {
            if (sim == null)
            {
                Console.WriteLine("Please insert SIM card");
            }
            else
            {
                Console.WriteLine("Calling... " + mobileNo);
            }
        }

        // Message Method
        public void msg(string mobileNo, string text)
        {
            if (sim == null)
            {
                Console.WriteLine("Please insert SIM card");
            }
            else
            {
                Console.WriteLine("Sending text message: " + text + " to MobileNo: " + mobileNo);
            }
        }
    }
}