# Lab-7-OOP-Generic-collections

# Om uppgiften

Denna labb handlar om att använda två vanliga generiska typer inom C#. Du kommer att skapa en klass och objekt utifrån den klassen som du sedan ska hantera genom Stack och List.

# Vad du ska göra

## Del 1 – Stack

- [ ]  Skapa en klass som heter `Employee`
    - [ ]  Denna klass ska ha flera egenskaper: Id, Name, Gender, Salary.
- [ ]  Skapa en Stack med objekt:
    - [ ]  I `Main()`-metoden ska du skapa fem objekt av klassen med olika Id, Name, Gender och Salary.
    - [ ]  Skapa sedan en `Stack` och lägg till de fem objekten du skapat med `Push()`.
- [ ]  Skriv ut alla objekt i stacken:
    - [ ]  Skriv ut alla objekt i din Stack.
    - [ ]  Du kan använda en foreach-loop för att skriva ut alla element i stacken.
    - [ ]  Efter varje rad eller element ska du skriva ut hur många objekt som finns kvar i stacken.
- [ ]  Hämta alla objekt med Pop-metoden:
    - [ ]  Hämta alla objekt i stacken genom `POP()`-metoden och skriv ut dem.
    - [ ]  Efter varje rad eller element ska du skriva ut hur många objekt som finns kvar i stacken.
    - [ ]  Lägg till alla objekt igen genom `Push()-`metoden.
- [ ]  Hämta objekt med Peek-metoden:
    - [ ]  Hämta två objekt med `Peek()-`metoden.
    - [ ]  Efter varje rad eller element ska du skriva ut hur många objekt som finns kvar i stacken.
- [ ]  Kolla om objekt nummer 3 finns i stacken eller inte och skriv ut resultatet.

![Output av Del 1 - Stack](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/7adac547-4fbd-4b1e-b983-a0663c6fff19/Capturegsgrg.png)

Output av Del 1 - Stack

## Del 2 – List

- [ ]  Skapa en List
- [ ]  Lägg in fem objekt av klassen `Employee` i din lista.
- [ ]  Skapa ett villkor med `Contains()-`metoden för att kolla om ett visst objekt finns i listan. Om det finns, skriv ut "Employee2 object exists in the list" i konsollen. Skriv annars ut "Employee2 object does not exist in the list".
- [ ]  Använd sedan `Find()-`metoden för att hitta och skriva ut det första objektet i listan som har `Gender = "Male"`.
- [ ]  Använd sedan `FindAll()-`metoden för att hitta och skriva ut alla objekt i listan som har `Gender = "Male"`

![Output av Del 2 - List](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/5fb05d32-92a2-4fe0-91d3-ae002318e8a9/assafs.png)

Output av Del 2 - List

# Din inlämning

- Skicka in en länk till uppgiften i Canvas.
- Skicka in en textfil som innehåller länken till ett Github-repo med din kod.