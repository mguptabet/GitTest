using System;

namespace Telephone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phone Example");

            SmartPhone phone = new SmartPhone("Samsung", "Galaxy S23", "Android", "5MP", "10MP");

            Console.WriteLine(phone._model + " " + phone._brand + " WiFi: " + phone._wifi);

            phone.sim = "Jio";

            Console.WriteLine("Calling...");
            string mobileNo = "9305047571";
            phone.call(mobileNo);

            Console.WriteLine("Sending message...");
            string msg = "Please call me";
            phone.msg(mobileNo, msg);

            string url = "google.com";

            Console.WriteLine("Internet starting...");
            phone.internet(url);

            Console.WriteLine("Turning WiFi on...");
            phone._wifi = "on";
            phone.internet(url);

            string cameraType = "front";
            phone.startCamera(cameraType);
            phone.clickPhoto();

            Console.WriteLine("Turning GPS ON...");
            phone.GPS("on");

            
            string startlocation = "Anpra";
            phone.Startjourney(startlocation);
            string endlocation = "varansi";
            phone.EndJourney(endlocation);
            phone.TrackLocation(startlocation, endlocation);
            int amount = 100000;
            phone.Checkbalance();
            phone.Pay(mobileNo, amount);
            phone.Checkbalance();

            phone.VideoCall("9876543210");

            string[] numbers = { "9876543212", "9876543213", "9876543214" };
            phone.ConferenceCall(numbers);

            string textmsg = "Hiii..";
            phone.Msg(mobileNo,textmsg);


            string[] nums = { "9876543214", "9876543215", "9876543292" };
            phone.GroupMessage(nums, "Hello");

            phone.WhatsAppCall("9999999999");

        }
    }
}