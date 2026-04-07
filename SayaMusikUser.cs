using System;
using System.Collections.Generic;
using System.Text;

namespace Modul6_103022400026
{
    internal class SayaMusikUser
    {
        private int id;
        public string Username { get; private set; }
        private List<SayaMusikTrack> uploadedTracks;

        public SayaMusikUser(string username)
        {
            if (username == null) throw new ArgumentNullException("Error: Username tidak boleh null");
            if (username.Length > 100) throw new ArgumentNullException("Error: Username maksima 100 karakter");
            Random random = new Random();
            this.Username = username;
            this.id = random.Next(10000, 10000000);
            this.uploadedTracks = new List<SayaMusikTrack>();
        }
        public int GetTotalPlayCount()
        {
            int total = 0;
            foreach (var track in uploadedTracks)
            {
                total += track.GetPlayCount();
            }
            return total;

        }
        public void AddTrack(SayaMusikTrack track)
        {
            if (track == null) throw new ArgumentNullException ("Error: judul tidak boleh null");
            if (track.GetPlayCount() == int.MaxValue) throw new ArgumentNullException ("Error: judul tidak boleh melebihi batas maksimal karakter");
            uploadedTracks.Add(track);
        }
        
    public void PrintAllTracks()
        {
            Console.WriteLine($"User: {Username}");
            int maxPrint = uploadedTracks.Count > 10? 10: uploadedTracks.Count;

            for (int i = 0; i < maxPrint; i++)
            {
                Console.WriteLine($"track{i + 1} judul {uploadedTracks[i].title}");
            }

        }
    }
}
