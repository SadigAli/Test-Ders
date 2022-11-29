using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTask
{
    internal class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int row;
        public int col;
        public bool[,] places = { };
        public Hall(int id,string name, int row, int col)
        {
            Id = id;
            Name = name;
            this.row = row;
            this.col = col;
            places = new bool[row, col];
        }

        public void GetStatus()
        {
            for (int i = 0; i < places.GetLength(0); i++)
            {
                for (int j = 0; j < places.GetLength(1); j++)
                {
                    Console.Write($"{places[i,j]} ");
                }
                Console.WriteLine("");
            }
        }

        public void OrderTicket(int id,string name,string lastname,string movie,DateTime start,DateTime end, int row, int column)
        {
            if (places[row-1,column-1] == false)
            {
                Ticket ticket = new Ticket();
                ticket.Id = id;
                ticket.Name = name;
                ticket.Lastname = lastname;
                ticket.Movie = movie;
                ticket.Start = start;
                ticket.End = end;
                ticket.Row = row;
                ticket.Column = column;

                Console.WriteLine(@$"Bilet nomresi :{Id} 
Ad,Soyad: {name} {lastname}
Filmin adi: {movie}
Baslama vaxti: {start.ToString("D hh::mm")}
Bitme vaxti: {end.ToString("D hh::mm")}
Sira ve sutun : {row} - {column}");
                places[row - 1,column - 1] = true;
            }
            else
            {
                Console.WriteLine("Bu yer artiq dolmushdur");
            }
        }
        
    }
}
