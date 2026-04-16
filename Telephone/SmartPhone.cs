using System;
using System.Security.Cryptography.X509Certificates;

namespace Telephone
{
    public class SmartPhone : KeypadPhone
    {
        public string _operatingSystem;
        public string _frontCamera;
        public string _backCamera;
        public string _wifi = "off";
        public string _gps = "off";

        public string _startlocation;
        public string _endlocation;

        public int balance = 1000;
        public int amount;

        public SmartPhone(string brand, string model, string operatingSystem, string frontCamera, string backCamera)
            : base(model, brand)
        {
            _operatingSystem = operatingSystem;
            _frontCamera = frontCamera;
            _backCamera = backCamera;
        }

        public void Insertsim()
        {
            if (sim == null)
            {
                Console.WriteLine("Please insert SIM card");
                return;
            }
        }

        public void WhatsAppCall(string mobileNo)
        {
            Insertsim();

            if (_wifi == "on" || sim == "jio")
            {
                Console.WriteLine("WhatsApp calling to " + mobileNo);
            }
            else
            {
                Console.WriteLine("Turn on internet for WhatsApp call");
            }
        }

        public void GroupMessage(string[] numbers, string text)
        {
            Console.WriteLine("GroupMessage...");
            if (sim == null)
            {
                Console.WriteLine("Please insert SIM card");
                return;
            }

            foreach (string num in numbers)
            {
                Console.WriteLine("Msg to " + num + ": " + text);
            }
        }

        public void Msg(string text, string mobileNo)
        {
            if (sim == null)
            {
                Console.WriteLine("Please insert SIM card");
            }

            Console.WriteLine("Sending text message: " + text + " to MobileNo: " + mobileNo);
        }

        public void VideoCall(string mobileNo)
        {
            if (sim == null)
            {
                Console.WriteLine("Please insert SIM card");
            }
            else if (_wifi == "on" || sim == "jio")
            {
                Console.WriteLine("Starting video call with " + mobileNo);
            }
            else
            {
                Console.WriteLine("Turn on WiFi or use internet SIM for video call");
            }
        }

        public void ConferenceCall(string[] mobileNumbers)
        {
            if (sim == null)
            {
                Console.WriteLine("Please insert SIM card");
            }
            else
            {
                Console.WriteLine("Starting conference call with:");

                foreach (string num in mobileNumbers)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public void GPS(string gps)
        {
            _gps = gps;
            Console.WriteLine("GPS is now: " + _gps);
        }
        public void TrackLocation(string startlocation ,string endlocation)
        {
            if (_gps == "on")
            {
                _startlocation = startlocation;
                _endlocation = endlocation;
                Console.WriteLine("Tracking location from " + _startlocation + " to " + _endlocation);
            }
            else
            {
                Console.WriteLine("Please turn on GPS");
            }
        }

        public void Pay(string mobileNo, int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Paid " + amount + " to " + mobileNo);
            }
        }
        public void Checkbalance()
        {
            Console.WriteLine("Balance: " + balance);
        }

        public void Startjourney(string startlocation)
        {
            _startlocation = startlocation;
            Console.WriteLine("Journey started from: " + _startlocation);
        }
        public void EndJourney( string endlocation)
        {
            _endlocation = endlocation;
            Console.WriteLine("Journey ended: " + _endlocation);
        }

        public void internet(string url)
        {
            if (_wifi == "on" || sim == "jio")
            {
                Console.WriteLine("Loading... " + url);
            }
            else
            {
                Console.WriteLine("Please insert SIM card or turn on WiFi");
            }
        }

        public void startCamera(string cameraType = "back")
        {
            Console.WriteLine("Camera started: " + cameraType);
        }

        public void clickPhoto()
        {
            Console.WriteLine("Photo clicked");
        }
    }
}
