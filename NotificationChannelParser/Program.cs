using System;
using System.Collections.Generic;
using System.Linq;

namespace NotificationChannelParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example input strings
            string input1 = "[BE][FE][Urgent] there is error";
            string input2 = "[BE][QA][HAHA][Urgent] there is error";

            // Parse and process each input
            Console.WriteLine(ParseNotificationChannels(input1));
            Console.WriteLine(ParseNotificationChannels(input2));
        }

        static string ParseNotificationChannels(string input)
        {
            // Extract tags from input (assuming they are enclosed in square brackets)
            var tags = input.Split('[', ']').Where(tag => !string.IsNullOrWhiteSpace(tag));

            // Define the relevant notification channels
            var relevantChannels = new HashSet<string> { "BE", "FE", "QA", "Urgent" };

            // Filter out relevant tags
            var relevantTags = tags.Where(tag => relevantChannels.Contains(tag));

            // Construct the output string
            string output = $"Receive channels: {string.Join(", ", relevantTags)}";

            return output;
        }
    }
}
