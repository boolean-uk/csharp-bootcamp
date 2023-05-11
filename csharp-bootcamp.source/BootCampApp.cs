

using System.Speech.Synthesis;

namespace csharp_bootcamp.source
{
    public class BootCampApp
    {
        private bool isRunning = true;
        private BootCampAcademy _academy;
        private SpeechSynthesizer _speechSynthesizer;
      
        public BootCampApp()
        {
            _academy = new BootCampAcademy();
            _academy.SeedData();
            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.SetOutputToDefaultAudioDevice();

        }
        public void Run()
        {
            while (isRunning)
            {
                Console.WriteLine("Welcome to BootCampApp");
                WriteCourses();
                WriteMenu();

                Console.WriteLine("Enter a command");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "q":
                        this.Stop();
                        break;
                    default:
                        Console.WriteLine($"you entered: {operation}");
                        _speechSynthesizer.Speak(operation);
                        //Console.Clear();
                        break;
                }
            }
        }
        public void Stop()
        {
            isRunning = false;
        }

        private void WriteMenu()
        {
            Console.WriteLine("q:  quit");
            
        }
        private void WriteCourses()
        {
            Console.WriteLine(new string('-',40));
            foreach(BootCampCourse course in _academy.Courses)
            {
                Console.WriteLine(course.Name);
            }
            Console.WriteLine(new string('-', 40));
        }
        
        public bool IsRunning { get => isRunning; set => isRunning = value; }
    }
}