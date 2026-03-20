# Exercitii Incapsulare

Aceste exercitii sunt gandite pentru o lectie introductiva de incapsulare in C#.

Ideea principala este:
- sa creezi modele noi
- sa alegi singur campurile
- sa scrii proprietati
- sa gandesti validatori potriviti pentru fiecare proprietate

Nu urmari doar sa mearga programul. Gandeste-te mereu:
- ce date are obiectul
- ce valori sunt corecte
- ce valori ar trebui blocate
- ce mesaj de eroare ar trebui afisat

## Reguli generale

La fiecare exercitiu:
- foloseste campuri `private`
- foloseste proprietati `public`
- adauga validare in `set`
- arunca `ArgumentException` pentru date invalide
- creeaza cel putin un obiect valid si unul invalid in `Program.cs`
- foloseste `try-catch`

## Exemplu de gandire

Daca ai proprietatea `Varsta`, nu este suficient sa spui doar "sa fie numar".

Trebuie sa te gandesti:
- poate fi negativa?
- poate fi 0?
- exista o limita maxima?
- ce mesaj afisez daca valoarea nu este buna?

## Exercitiul 1
Creeaza modelul `Elev`.

Alege singur proprietatile.

Exemple de proprietati:
- `Nume`
- `Prenume`
- `Varsta`
- `Clasa`
- `Medie`

Gandeste validatori pentru fiecare.

Exemple de intrebari:
- numele poate fi gol?
- numele poate contine cifre?
- varsta poate fi mai mica decat 6?
- media poate fi mai mare decat 10?

## Exercitiul 2
Creeaza modelul `Carte`.

Exemple de proprietati:
- `Titlu`
- `Autor`
- `AnAparitie`
- `NumarPagini`
- `Pret`

Gandeste validatori pentru fiecare.

Intrebari care te pot ajuta:
- titlul poate fi gol?
- autorul poate contine cifre?
- anul aparitiei poate fi in viitor?
- numarul de pagini poate fi 0?
- pretul poate fi negativ?

## Exercitiul 3
Creeaza modelul `Telefon`.

Exemple de proprietati:
- `Brand`
- `Model`
- `MemorieGB`
- `Pret`
- `Culoare`

Incearca sa alegi tu reguli potrivite.

Exemple:
- brandul sa nu fie gol
- memoria sa fie intr-un interval realist
- pretul sa fie mai mare decat 0

## Exercitiul 4
Creeaza modelul `ContBancar`.

Exemple de proprietati:
- `Titular`
- `IBAN`
- `Sold`
- `Moneda`

Gandeste validatori mai atenti.

Exemple de idei:
- titularul nu poate fi gol
- soldul nu poate fi negativ
- moneda sa fie doar `RON`, `EUR` sau `USD`
- IBAN-ul sa aiba o lungime minima

## Exercitiul 5
Creeaza modelul `Produs`.

Exemple de proprietati:
- `Denumire`
- `Pret`
- `Stoc`
- `Categorie`
- `CodProdus`

Gandeste tu validari pentru fiecare proprietate.

Dupa aceea raspunde:
1. Ce proprietate a fost cel mai usor de validat?
2. Ce proprietate a fost cel mai greu de validat?
3. De ce?

## Exercitiul 6
Creeaza modelul `Pacient`.

Exemple de proprietati:
- `Nume`
- `Varsta`
- `Greutate`
- `Inaltime`
- `GrupaSange`

Aici trebuie sa te gandesti mai atent la validatori.

Exemple:
- varsta sa fie intr-un interval realist
- greutatea sa fie pozitiva
- inaltimea sa fie intr-un interval realist
- grupa de sange sa accepte doar valori cunoscute

## Exercitiul 7
Creeaza modelul `MasinaNoua` fara sa te uiti la clasa existenta `Masina`.

Alege singur proprietatile si validatorii.

Posibile proprietati:
- `Marca`
- `Model`
- `AnFabricare`
- `Combustibil`
- `Pret`
- `Kilometri`

La final compara modelul tau cu clasa deja existenta.

## Exercitiul 8
Alege singur un model din viata reala.

Exemple:
- `Profesor`
- `Laptop`
- `Film`
- `Comanda`
- `AnimalDeCompanie`

Creeaza:
- minimum 5 proprietati
- minimum 5 validatori

## Exercitiul 9
Pentru unul dintre modelele create de tine, adauga:
- constructor fara parametri
- constructor cu parametri

Intrebare:
- de ce este util constructorul cu parametri?

## Exercitiul 10
Pentru unul dintre modelele create, scrie o metoda:
- `AfisareDetalii()`

Cerinta:
- sa afiseze toate datele obiectului intr-un format clar

## Exercitiul 11
Pentru doua modele create de tine, scrie in caiet sau in comentarii:
- ce validator ai adaugat la fiecare proprietate
- de ce ai ales acel validator

Acesta este exercitiul cel mai important.

Scopul nu este doar sa scrii cod, ci sa justifici regulile.

## Exercitiul 12
Creeaza intentionat obiecte invalide.

Exemple:
- nume gol
- pret negativ
- an prea mare
- stoc negativ
- text cu caractere nepermise

Verifica daca validatorii tai chiar functioneaza.

## Idei de validatori

Poti gandi validatori precum:
- sa nu fie gol
- sa nu fie `null`
- sa aiba lungime minima
- sa aiba lungime maxima
- sa accepte doar litere
- sa accepte litere si cifre
- sa nu accepte caractere speciale
- sa fie mai mare decat 0
- sa fie mai mare sau egal cu 0
- sa fie intr-un interval
- sa nu fie in viitor
- sa fie una dintre valorile permise

## Intrebari bune pentru orice proprietate

Cand alegi un validator, intreaba-te:
1. Poate fi goala?
2. Poate fi negativa?
3. Are o limita maxima?
4. Poate contine orice caractere?
5. Are un set fix de valori posibile?
6. Exista valori nerealiste care ar trebui blocate?

## Sarcina finala

Alege 3 modele diferite si implementeaza pentru fiecare:
- minimum 4 proprietati
- minimum 4 validatori
- un constructor cu parametri
- un exemplu valid
- un exemplu invalid

## Scopul lectiei

Dupa aceste exercitii ar trebui sa poti:
- creezi un model simplu
- ascunzi campurile cu `private`
- controlezi accesul prin proprietati
- protejezi obiectul cu validatori
- explici de ce o regula este utila
