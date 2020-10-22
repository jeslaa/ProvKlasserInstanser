using System;
using System.Collections.Generic;

namespace ProvKlasserInstanser
{
    public class Book
    {
        public int price;

        private string name = "";

        private int rarity;

        private string category; 

        private int actualValue;

        private bool cursed;

        private Random generator;

        List<string> bokNamn = new List<string>();
        
        //listor av böcker som ska slumpas i metoden Book
        List<string> fantasyBöcker = new List<string>();

        List<string> actionBöcker = new List<string>();

        List<string> dramaBöcker = new List<string>();



        public Book(){
            
        }

        public void PrintInfo(){

        }

        public int Evaluate(){

        } 

        public string GetCategory(){

        }

        public string GetName(){

        }

        public bool IsCursed(){

        }
    }
}
