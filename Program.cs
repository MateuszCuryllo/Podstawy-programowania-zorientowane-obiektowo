
using System;
using System.Collections.Generic;

namespace WypozyczalniaGier
{
  
    public class GraKomputerowa
    {
       
        public string Tytul { get; set; }
        public string Platforma { get; set; }
        public bool CzyWypozyczona { get; private set; }
        public decimal KosztWypozyczenia { get; } 
     
        public void Wypozycz()
        {
          CzyWypozyczona =true;
        }
        public void Zwroc()
        {
           CzyWypozyczona =false;
        }
        public void PokazInformacje()
        {
            
        }
    }

    public class ZarzadcaWypozyczalni
    {
        public List<GraKomputerowa> KatalogGier = new List<GraKomputerowa>();

        public void WyswietlWszystkieGry()
        {

        }
    }
}