using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    public enum Stato
    {
        disponibile=1,
        in_prestito=0
    }
   public class Persona
    {
        public string nome { get; set; } 
        public string cognome { get; set; }    
    }
    public class Utente : Persona
    {
        public string email { get; set; }
        public string password { get; set; }
      
        public int telefono { get; set; }
    }

    public class Autore: Persona
    {

    }

    public class Documento
    {
        public string id { get; set; }
        public string titolo { get; set; }
        public string settore { get; set; }
        public Stato stato { get; set; }
        public DateTime anno { get; set; }
        public string scaffale { get; set; }

        public List<Autore> autori { get; set; }
    }
    public class Libri: Documento
    {
        public int n_pagine { get; set; }
    }

    public class DVD : Documento
    {
        public int min_durata { get; set; }
    }

    public class Prestito
    {
        public Utente utente { get; set;}
        public Documento documento { get; set;}
        public DateTime inizio_prestito { get; set;}
        public DateTime fine_prestito { get; set;}
    }

    public class Biblioteca
    {
        public List<Utente> utenti { get; set; }
        public List<Documento> documenti { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
