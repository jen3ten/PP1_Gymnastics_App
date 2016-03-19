using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1_GymnasticsApp
{
    class Meet
    {
        //Fields
        private string name = "";
        private string host = "";
        private string venue = "";
        private string city = "";
        private DateTime eventDate;
        private DateTime eventTime;
        private int level = 0;
        private string ageGroup = "";
        private int groupSize = 0;
        private double ticketCost = 0.0;
        private string website = "";         //Link to host website
        private string schedule = "";        //Link to schedule

        private double vaultScore = 0.0;
        private int vaultPlace = 0;
        private bool vaultPB = false;
        private double barScore = 0.0;
        private int barPlace = 0;
        private bool barPB = false;
        private double beamScore = 0.0;
        private int beamPlace = 0;
        private bool beamPB = false;
        private double floorScore = 0.0;
        private int floorPlace = 0;
        private bool floorPB = false;
        private double overallScore = 0.0;
        private int overallPlace = 0;
        private bool overallPB = false;
        private double teamScore = 0.0;
        private int teamPlace = 0;

        //Properties
        public string Name { get; set; }
        public string Host { get; set; }
        public string Venue { get; set; }
        public string City { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public int Level { get; set; }
        public string AgeGroup { get; set; }
        public int GroupSize { get; set; }
        public double TicketCost { get; set; }
        public string Website { get; set; }
        public string Schedule { get; set; }

        public double VaultScore { get; set; }
        public int VaultPlace { get; set; }
        public bool VaultPB { get;  set; }
        public double BarScore { get; set; }
        public int BarPlace { get; set; }
        public bool BarPB { get; set; }
        public double BeamScore { get; set; }
        public int BeamPlace { get; set; }
        public bool BeamPB { get; set; }
        public double FloorScore { get; set; }
        public int FloorPlace { get; set; }
        public bool FloorPB { get; set; }
        public double OverallScore { get; set; }
        public int OverallPlace { get; set; }
        public bool OverallPB { get; set; }
        public double TeamScore { get; set; }
        public int TeamPlace { get; set; }

        //Constructor
        public Meet()
        {
            EnterMeetInfo();
        }

        public Meet(string name, string city, int level)
        {
            this.Name = name;
            this.City = city;
            this.EventDate = eventDate;
            this.Level = level;
        }

        //Methods
        //EnterMeetInfo()- Allows user to enter a new meet and all information about that meet such as name, host, venue, city, date, time, etc...
        public void EnterMeetInfo()
        {
            Console.WriteLine("ENTER THE FOLLOWING INFORMATION ABOUT THE MEET");
            Console.Write("Meet Name: ");
            this.Name = Console.ReadLine();
        }
    }
}
