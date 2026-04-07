using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6_103022400026
{
    internal class SayaMusikTrack
    {
        private int id;
        public string title;
        private int playCount;

        public SayaMusikTrack (string title)
        {
            if (title == null)
            
                throw new ArgumentNullException ("title tidak boleh null");
            if (title.Length > 200) throw new ArgumentException("title track maksimal 200 title");
            Random random = new Random ();
            this.id = random.Next (10000, 1000000);
            this.title = title;
            this.playCount = 0;
        }


        public void IncreasePlayCount(int playCount)
        {
            if (playCount < 0) throw new ArgumentException("playcount tidak boleh negative");
            if (playCount > 25000) throw new ArgumentException("maksimal penambahan 25000 pemanggilan");
            try
            {
                checked
                {
                    this.playCount = playCount;
                }
            }
            catch (OverflowException) 
            {
                Console.WriteLine("terjadi overflow pada playCount");
            }
            
        }

        public int GetPlayCount()
        {

            return playCount;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine($"Id:  {id}");
            Console.WriteLine($"Title:  {title}");
            Console.WriteLine($"PlayCount:  {playCount}");
        }
    }
}
