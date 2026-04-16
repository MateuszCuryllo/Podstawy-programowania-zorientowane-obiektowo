
class FoodItem:
    def __init__(self, nazwa, kalorie_na_100g):
        self.nazwa = nazwa
        self.kalorie_na_100g = kalorie_na_100g

    def oblicz_kalorie(self, waga):
        return (waga / 100) * self.kalorie_na_100g

class Meal:
    def __init__(self, nazwa_posilku):
        self.nazwa_posilku = nazwa_posilku
        self.skladniki = []

    def dodaj_produkt(self, produkt, waga):
        self.skladniki.append((produkt, waga))
        print(f"Dodano {waga}g {produkt.nazwa} do posiłku: {self.nazwa_posilku}")

    def suma_kalorii_posilku(self):
        total = 0
        for produkt, waga in self.skladniki:
            total += produkt.oblicz_kalorie(waga)
        return total

class DailyIntake:
    def __init__(self, data):
        self.data = data
        self.posilki = []

    def dodaj_posilek(self, posilek):
        self.posilki.append(posilek)

    def wyswietl_podsumowanie(self):
        print(f"\n--- Podsumowanie dnia: {self.data} ---")
        suma_dnia = 0
        for p in self.posilki:
            kalorie = p.suma_kalorii_posilku()
            suma_dnia += kalorie
            print(f"{p.nazwa_posilku}: {kalorie:.2f} kcal")
        
      
        print(f"CAŁKOWITE SPOŻYCIE: {suma_dnia:.2f} kcal")




chleb = FoodItem("Chleb żytni",250)
maslo = FoodItem("Masło",717)
kurczak = FoodItem("Pierś z kurczaka", 165)
ryz = FoodItem("Ryż",350)
pomidor = FoodItem("Pomidor",18)
twarog = FoodItem("Twaróg chudy",100)

sniadanie = Meal("Śniadanie")
sniadanie.dodaj_produkt(chleb,100)
sniadanie.dodaj_produkt(maslo,10)


obiad = Meal("Obiad")
obiad.dodaj_produkt(kurczak,200)
obiad.dodaj_produkt(ryz,50)
obiad.dodaj_produkt(pomidor,150)


kolacja = Meal("Kolacja")
kolacja.dodaj_produkt(twarog, 150)
kolacja.dodaj_produkt(pomidor, 100)


dzien = DailyIntake("2026-04-10")
dzien.dodaj_posilek(sniadanie)
dzien.dodaj_posilek(obiad)
dzien.dodaj_posilek(kolacja)

dzien.wyswietl_podsumowanie()








  