using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PP1_GymnasticsApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<Meet> meetList = new List<Meet>();
            StreamWriter meetTextFile = new StreamWriter("meetTextFile.txt");

            meetList.Add(new Meet("Arnold Classic", "Columbus, OH", 5));
            int i = 0;
            do
            {
                //Meet meet1 = new Meet();
                //meetList.Add(meet1);
                meetList.Add(new Meet());
                Console.WriteLine("This is what the list shows for meet object: {0}", meetList[i]);
                Console.WriteLine("This is what the list shows for meet object property 'Name': {0}", meetList[i].Name);
                meetTextFile.WriteLine(meetList[i]);

                //Console.WriteLine("This is what you entered: {0}", meetList[i].Name);
                //Console.WriteLine(meetList[0].Name);

                int meetNum = meetList.Count();
                Console.WriteLine("Num meets in list is {0}", meetNum);

                //StringBuilder meetObjectName = new StringBuilder();
                //meetObjectName.Append("meet");
                //meetObjectName.Append(meetNum + 1);
                //meetObjectName.ToString();
                i++;
                Console.ReadLine();

            } while (i < 5);

                meetTextFile.Close();
            foreach(Meet meet in meetList)
            {
                Console.WriteLine(meet.Name);
            }


        }
    }
}
