using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace TestConsole
{
    class Program
    {       
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //Hashtable hash = new Hashtable();
            //Dictionary<int, string> hash = new Dictionary<int, string>();
            Dictionary<int, DbType> hash = new Dictionary<int, DbType>();

            //hash.Add(1, "Pain");
            //hash.Add(2, "Eau");
            //hash.Add(3, "Fraise");
            //hash.Add(4, "Salade");
            //hash.Add(5, "Raisin");
            //hash.Add(6, "Coco");
            //hash.Add(7, "Arachide");

            hash.Add(1, DbType.Int32);
            hash.Add(2, DbType.String);
            hash.Add(3, DbType.Double);
            hash.Add(4, DbType.String);
            hash.Add(5, DbType.Decimal);
            hash.Add(6, DbType.Boolean);
            hash.Add(7, DbType.Single);

            ICollection v = hash.Values;

            sw.Start();

            for (int i = 0; i < hash.Count; i++)
            {
                Console.WriteLine(hash[4]);
            }
            sw.Stop();
            Console.WriteLine("Delais1 = {0} Sec", Convert.ToString((float)sw.ElapsedMilliseconds / 1000));

            foreach (object col in v)
            {
                Console.WriteLine(col.ToString());
            }
            sw.Stop();
            Console.WriteLine("Delais2 = {0} Sec", Convert.ToString((float)sw.ElapsedMilliseconds / 1000));

            sw.Start();
            IDictionaryEnumerator dic = hash.GetEnumerator();
            
            while (dic.MoveNext())
            {
                if (dic.Value.ToString().Equals(DbType.Single.ToString()))
                {
                    Console.WriteLine("key = {0} et value = {1}", dic.Key.ToString(), dic.Value.ToString());
                }
            }

            sw.Stop();
            Console.WriteLine("Delais3 = {0} Sec", Convert.ToString((float)sw.ElapsedMilliseconds / 1000));

            sw.Start();
            IEnumerator didi = hash.GetEnumerator(); 

            while (didi.MoveNext())
            {
                Console.WriteLine(didi.ToString());
            }

            sw.Stop();
            Console.WriteLine("Delais4 = {0} Sec", Convert.ToString((float)sw.ElapsedMilliseconds / 1000));
            //for (int i = 0; i < 6; i++ )
            //{
            //    Console.WriteLine(hash[]);
            //}

            sw.Stop();
            //Console.WriteLine("Serveur = {0}\nDatabase = {1}\nUser = {2}\nPassword = {3} ", serveur, database, user, password);
            //Console.WriteLine("Delais = {0} Sec", Convert.ToString((float)sw.ElapsedMilliseconds/1000));

            //string s = Environment.SystemDirectory.ToString().Substring(0, 3) + Environment.SpecialFolder.System.ToString() + @"\";
            //Console.WriteLine("Repertoire de travail = " + s);
            ////////Stopwatch sw = new Stopwatch();
            ////////sw.Start();
            ////////IEnumerable<int> er = Enumerable.Range(1, 20);
            ////////IEnumerable<int> rs = from x in er
            ////////                     where x % 5 == 0
            ////////                     select x;

            ////////foreach (var ern in rs)
            ////////{
            ////////    //Console.WriteLine(ern.ToString());
            ////////}
            ////////sw.Stop();
            ////////Console.WriteLine("Temp d'execution1 = " + (float)sw.ElapsedMilliseconds / 1000 + "S");

            ////////sw.Start();
            ////////for (int i = 1; i < 20; i++ )
            ////////{
            ////////    if(i %5 == 0)
            ////////    {
            ////////        //Console.WriteLine(i.ToString());
            ////////    }
            ////////}
            ////////sw.Stop();

            ////////Console.WriteLine("Temp d'execution2 = " + (float)sw.ElapsedMilliseconds / 1000 + "S");
            
            ////////for (int i = 0; i < args.Length; i++)
            ////////{
            ////////    Console.WriteLine("args[" + i + "] = " + args[i]);
            ////////}

            ////////Regex r = new Regex("Pest est une perle noire et morte", RegexOptions.Compiled);
            ////////Console.WriteLine("DateTime.MaxValue.Ticks.ToString() = " + DateTime.Now.Ticks.ToString());
            ////////Console.WriteLine("TimeZone.CurrentTimeZone.ToString() = " + TimeZone.CurrentTimeZone.DaylightName.ToString());
            ////////Console.WriteLine("=====Environment.SystemDirectory = " + Environment.SystemDirectory);
            //////////Console.WriteLine("Environment.SpecialFolder.ApplicationData.ToString() = " + Environment.ToString());
            ////////Console.WriteLine("Environment.SystemDirectory = " + Environment.UserName + " et " + Environment.Version +
            ////////    " " + Environment.OSVersion + "; " + Environment.OSVersion.Platform + "; " + Environment.OSVersion.VersionString +
            ////////    "; " + Environment.OSVersion.Version + "; " + PlatformID.Win32NT.ToString());

            ////////string[] tb = Enum.GetNames(typeof(Environment.SpecialFolder));
            ////////foreach (string str in tb)
            ////////{
            ////////    Console.WriteLine(str);
            ////////}

            ////////Console.WriteLine("=================================================\n");

            ////////foreach (string str in Environment.GetLogicalDrives())
            ////////{
            ////////    Console.WriteLine(str);
            ////////    Console.WriteLine(str[0]);
            ////////}

            ////////Console.WriteLine("=================================================\n");

            ////////string[] tb1 = Enum.GetNames(typeof(EnvironmentVariableTarget));

            ////////foreach (string str in tb1)
            ////////{

            ////////    Console.WriteLine(str);
            ////////}

            ////////Console.WriteLine("=================================================\n");

            //int j = 0;
            //IDictionary id = Environment.GetEnvironmentVariables()["ALLUSERSPROFILE"];

            //foreach (string str in id.Keys)
            //{
            //    //Console.WriteLine(str + " : " + id[str]);
            //    Console.WriteLine("Repertoire de travail = " + id["ALLUSERSPROFILE"]);
            //    break;
            //}

            //foreach (string str in Environment.GetEnvironmentVariables().Keys)
            //{
                //Console.WriteLine(str + " : " + id[str]);
                Console.WriteLine("Repertoire de travail = " + Environment.GetEnvironmentVariables()["ALLUSERSPROFILE"]);
            //    break;
            //}

            ////////Console.WriteLine("=================================================\n");

            ////////WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            ////////Console.WriteLine(wp.Identity.Name);

            ////////if (wp.IsInRole("Administrators"))
            ////////{
            ////////    Console.WriteLine("Est un admin\n");
            ////////}

            ////////Console.WriteLine("ConfigurationManager.ConnectionStrings[\"conStringGestionPersonne\"].ConnectionString = \n" + ConfigurationManager.ConnectionStrings["conStringGestionPersonne"].ConnectionString);


            Console.ReadLine();

            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            
            //Console.WriteLine(st);
            //Console.Title = "Mon Test";
            ////Console.Beep(32767, 2000);
            //Console.Beep(767, 10000);
        }
    }
}
