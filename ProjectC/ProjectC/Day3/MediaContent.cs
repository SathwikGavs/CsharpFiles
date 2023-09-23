using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC.Day3
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("Start");

        }

        public void StopPlayingContent() 
        {
            Console.WriteLine("Stop");
                
        }

        public void PausePlayingContent()
        { 
            
            Console.WriteLine("Pause");
        
        }

        public void ContinuePlayingContent() 
        
        {

            Console.WriteLine("Continue");


        }


    }

    internal class AudioContent : MediaContent
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("Start from audioContent");
        }

        public override string ToString()
        {
            Console.WriteLine("AudioContent ToString");
            return "AudioContent";
        }


    }

    internal class VideoContent : MediaContent 
    {
    
    
    
    }

    internal class MediaTester
    {
        public static void TestOne()
        {




        }


    }


}
