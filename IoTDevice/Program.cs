using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDevice
{
    class Program
    {

        // The device connection string to authenticate the device with your IoT hub.
        // Using the Azure CLI:
        // az iot hub device-identity show-connection-string --hub-name {YourIoTHubName} --device-id MyDotnetDevice --output table


        private readonly static string s_connectionString = "";

        static void Simulate()
        {
            // Connect to the IoT hub using the MQTT protocol
            SimulatedDevice.s_deviceClient = DeviceClient.CreateFromConnectionString(s_connectionString, TransportType.Mqtt);
            SimulatedDevice.SendDeviceToCloudMessagesAsync();
        }

        static void SimulateWithMethod()
        {

        }
        static void Main(string[] args)
        { 
            Console.WriteLine("IoT Hub Quickstarts #1 - Simulated device. Ctrl-C to exit.\n");

            Console.ReadLine();
        
    }
    }
}
