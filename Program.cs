

using System;
using System.Speech.Synthesis;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added this project to GITHUB

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
            synth.Speak("Can you Type in Your Name please ?");
            Console.WriteLine("Your Name");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name+"! Welcome to C# Programming");
            synth.Speak("Hello "+name+"! Welcome to C# Programming");
            Console.WriteLine("How many hours of sleep did you get last night ??");
            synth.Speak("How many hours of sleep did you get last night");
            int hourofSleep = int.Parse(Console.ReadLine());
            if(hourofSleep >=8)
            {
                Console.WriteLine("You Have Enough Sleep");
                synth.Speak("Good! You have Enough Sleep");
            }
            else
            {
                Console.WriteLine("You need more sleep");
                synth.Speak(name+" ! You need to Rest more!");
            }
        }
    }
}
