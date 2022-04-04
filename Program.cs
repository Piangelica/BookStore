/*Esercizio:
In questo esercizio vogliamo inserire in maniera “hardcoded” (ossia scritte nel codice senza dover chiedere all’utente nessun input) tutte le informazioni 
che troviamo su Amazon di un libro (per esempio "Clean Code") per poi stamparne una piccola sintesi fatta bene.
Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
- Titolo
- Autore
- ISBN
- Numero pagine
- Peso del libro
- Larghezza, Altezza e Profondità del libro
- Valutazione media
- Numero di recensioni
- se è disponibile in versione Kindle
- se la copertina flessibile è disponibile
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.
Un esempio è il seguente:
——— IL LIBRO DI OGGI: << titolo >> di << autore >>——————-
    Informazioni generiche:
ISBN: << isbn >>
Numero delle pagine: << numeroPagine >> pagine
Peso del libro: << pesoLibro >> kg
Dimensioni del libro: << larghezza >> cm x << lunghezza >> cm x << profondita >> cm
Informazioni Amazon:
Valutazione media: << valutazioneMedia >> stelline
Numero di recensioni: << numeroRecensioni >> recensioni

Kindle disponibile: Si o No
Copertina flessibile disponibile: Si o No*/
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Titolo del Libro:");
string TitoloLibro = Console.ReadLine();
Console.Write("Autore:");
string AutoreLibro = Console.ReadLine();
Console.Write("ISBN:");
int ISBN = int.Parse(Console.ReadLine());
Console.Write(value: "Numero delle pagine:");
int numeroPagine = int.Parse(Console.ReadLine());
Console.Write(" Peso del libro:");
float pesoLibro = float.Parse(Console.ReadLine());
Console.WriteLine("Dimensioni del libro:");
Console.Write("larghezza:");
float LarghezzaLibro = float.Parse(Console.ReadLine());
Console.Write("altezza:");
float AltezzaLibro = float.Parse(Console.ReadLine());
Console.Write("profondità:");
 float ProfonditàLibro = float.Parse(Console.ReadLine());
Console.Write(" Valutazione dei Media:");
float ValutazioneMedia = float.Parse(Console.ReadLine());
Console.Write(" Numero di recensioni:");
int NumeroRecensioniLibro = int.Parse(Console.ReadLine());
Console.Write("Kindle disponibile:");
string DisponibilitàVersioneKindle = Console.ReadLine();
Console.Write("Copertina flessibile disponibile:");
string DisponibilitàCopertinaFlessibile = Console.ReadLine();
