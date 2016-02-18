using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Face_Race_Picker
{
    public struct player
    {
        public string name;
        public string face;
        public string race;

    };

    public class league
    {
        public league()
        {
            Players = new List<player>();
        }
        public void ReadPlayers()
        {
            string filename = "Csv.txt";
            using (CsvFileReader reader = new CsvFileReader(filename))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    player p = new player();
                    int i = 0;
                    foreach (string s in row)
                    {
                        if (i == 0)
                        {
                            p.name = s;
                        }
                        else if (i == 1)
                        {
                            p.face = s;
                        }
                        else if (i == 2)
                        {
                            p.race = s;
                        }
                        else
                        {
                            break;
                        }
                        i++;
                    }
                    Players.Add(p);
                }
            }
        }
        public void WritePlayers() 
        {
            string filename = "Csv.txt";
            using (CsvFileWriter writer = new CsvFileWriter(filename))
            {
                foreach (player p in Players)
                {
                    CsvRow row = new CsvRow();
                    row.Add(p.name + "," + p.face + "," + p.race);
                    writer.WriteRow(row);
                }
            }
        }
        public void EditPlayer(int index, string face, string race)
        {
            if (index == -1)
                return;
            player p = new player();
            p = Players[index];
            p.face = face;
            p.race = race;
            Players[index] = p;
        }
        public int Find_Index(string name)
        {
            return Players.FindIndex(p => p.name == name);
        }
        public List<player> Players;
    }

    public class CsvRow : List<string>
    {
        public string LineText { get; set; }
    }

    public class CsvFileWriter : StreamWriter
    {
        public CsvFileWriter(Stream stream)
            :base(stream)
        {
        }

        public CsvFileWriter(string filename)
            :base(filename)
        {
        }

        public void WriteRow(CsvRow row)
        {
            StringBuilder builder = new StringBuilder();
            bool firstColumn = true;
            foreach (string value in row)
            {
                if (!firstColumn)
                {
                    builder.Append(',');
                }
                builder.Append(value);
            }
            row.LineText = builder.ToString();
            WriteLine(row.LineText);
        }
    }

    public class CsvFileReader : StreamReader
    {
        public CsvFileReader(Stream stream) 
            :base(stream)  
        { }

        public CsvFileReader(string filename)
            : base(filename)
        { }

        public bool ReadRow(CsvRow row)
        {
            row.LineText = ReadLine();
            if (String.IsNullOrEmpty(row.LineText))
            {
                return false;
            }
            int pos = 0;
            int rows = 0;

            while (pos < row.LineText.Length)
            {
                string value;

                int start = pos;
                while (pos < row.LineText.Length && row.LineText[pos] != ',')
                {
                    pos++;
                }
                value = row.LineText.Substring(start, pos - start);

                if (rows < row.Count)
                {
                    row[rows] = value;
                }
                else
                {
                    row.Add(value);
                }
                rows++;

                while (pos < row.LineText.Length && row.LineText[pos] != ',')
                {
                    pos++;
                }
                if (pos < row.LineText.Length)
                {
                    pos++;
                }
            }
            while (row.Count > rows)
            {
                row.RemoveAt(rows);
            }
            return (row.Count > 0);
        }
    }

}
