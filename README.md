# Maciej Owczarski s33681 - APBD-Cw2-s33681

## Kohezja
* O kohezje zadbalem np wyliczając automatycznie właściwość WTerminie w klasie Wypozyczenie

* Dostepnosc Device zmienia sie za pomoca metod Availble() i Unavailable()

* Kara w person nalicza się za pomocą metod AddPenalty() i PayPenalty()

## Coupling

* Nie licze wszystkiego w Service tylko zwrot deleguje do Wypozyczenie i tam jest wszstko wyliczane (Kary i daty)

## SOLID
* **S** - klasy Person, Device, Wypozyczenie przechowuja tylko swoje dane i logike do zarzadzania nimi
* **O** - dziedziczenie w klasach Person i Device (maja one wszystkie potrzebne dane do dzialania seriwsu a zeby dodac nowy przedmiot wystarczy dopisac klase ktora dziedziczy po nich)
* **L** - do list w service uzywam klas abstrakcyjnych ktore sa na samej gorze dzieki czemu moge wrzucac wszytskie klasy dziedziczace po nich
* **I** - nie mam interfejsów
* **D** - dane mam w Listach w kodzie, nie wczytuje ich