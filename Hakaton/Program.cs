﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProcTaskOwn
{
    class Program
    {
        static void Main(string[] args)
        {
           /*  char id = Console.ReadKey().KeyChar;
            HttpWebRequest request =
                (HttpWebRequest)WebRequest.Create(string.Format("http://kodaday.intita.com/api/task/{0}", id));
            request.Headers.Add("X-API-KEY: S95Xczjx");

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();*/






            Sourse json = new Sourse();
           // json = JsonConvert.DeserializeObject<Sourse>(responseFromServer);


           
            Answer answer = new Answer(json);
            Holder holder = new Holder(json);
            holder.distrib_Priorities();

            Sort sort = new Sort();
            sort.SortFunc(holder.Type0);
            sort.SortFunc(holder.Type1);
            sort.SortFunc(holder.Type2);


            sort.SortFunc(holder.ProcList);
            sort.GetAnswer(holder.ProcList, json, answer);
            answer.Print();
            Console.WriteLine(holder.ProcList[0].load);
            /*HttpWebRequest request2 =
            (HttpWebRequest)WebRequest.Create(string.Format("http://kodaday.intita.com/api/task/{0}", id));
            request2.Headers.Add("X-API-KEY: S95Xczjx");
            request2.Method = "POST";
            var stream = request2.GetRequestStream();
            var writer = new StreamWriter(stream);
            writer.Write(JsonConvert.SerializeObject(answer.answerMass));
            writer.Flush();
            writer.Close();
            stream.Close();
            WebResponse response2 = request2.GetResponse();
            Console.WriteLine(response2);
            */
            Console.ReadKey();

        }
    }
}
