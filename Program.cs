// See https://aka.ms/new-console-template for more information
using Modul6_103022400026;
using System;

class Program
{
    static void Main(String[] args)
    {
        try
        {
            SayaMusikUser user = new SayaMusikUser("Preciosa");
            SayaMusikTrack t1 = new SayaMusikTrack("Fix you");
            SayaMusikTrack t2 = new SayaMusikTrack("Stuck with you");
            SayaMusikTrack t3 = new SayaMusikTrack("Kiss you");
            SayaMusikTrack t4 = new SayaMusikTrack("Bingo");
            SayaMusikTrack t5 = new SayaMusikTrack("Magic");
            SayaMusikTrack t6 = new SayaMusikTrack("I would");
            SayaMusikTrack t7 = new SayaMusikTrack("Heart Attack");
            SayaMusikTrack t8 = new SayaMusikTrack("Skateboard");
            SayaMusikTrack t9 = new SayaMusikTrack("Photograph");
            SayaMusikTrack t10 = new SayaMusikTrack("Shallow");

            t1.IncreasePlayCount(100);
            t2.IncreasePlayCount(200);
            t3.IncreasePlayCount(300);


            user.AddTrack(t1);
            user.AddTrack(t2);
            user.AddTrack(t3);
            user.AddTrack(t4);
            user.AddTrack(t5);
            user.AddTrack(t6);
            user.AddTrack(t7);
            user.AddTrack(t8);
            user.AddTrack(t9);
            user.AddTrack(t10);

            user.PrintAllTracks();
            Console.WriteLine("Total PlayCount: " + user.GetTotalPlayCount());

            SayaMusikTrack overFlowTes = new SayaMusikTrack("overFlowTes");
            for (int i = 0; i < 100; i++)
            {
                overFlowTes.IncreasePlayCount(int.MaxValue);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}


