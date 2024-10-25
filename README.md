# Lab-7-OOP-Generic-collections

# Om uppgiften

Denna labb handlar om att anv�nda tv� vanliga generiska typer inom C#. Du kommer att skapa en klass och objekt utifr�n den klassen som du sedan ska hantera genom Stack och List.

# Vad du ska g�ra

## Del 1 � Stack

- [ ]  Skapa en klass som heter `Employee`
    - [ ]  Denna klass ska ha flera egenskaper: Id, Name, Gender, Salary.
- [ ]  Skapa en Stack med objekt:
    - [ ]  I `Main()`-metoden ska du skapa fem objekt av klassen med olika Id, Name, Gender och Salary.
    - [ ]  Skapa sedan en `Stack` och l�gg till de fem objekten du skapat med `Push()`.
- [ ]  Skriv ut alla objekt i stacken:
    - [ ]  Skriv ut alla objekt i din Stack.
    - [ ]  Du kan anv�nda en foreach-loop f�r att skriva ut alla element i stacken.
    - [ ]  Efter varje rad eller element ska du skriva ut hur m�nga objekt som finns kvar i stacken.
- [ ]  H�mta alla objekt med Pop-metoden:
    - [ ]  H�mta alla objekt i stacken genom `POP()`-metoden och skriv ut dem.
    - [ ]  Efter varje rad eller element ska du skriva ut hur m�nga objekt som finns kvar i stacken.
    - [ ]  L�gg till alla objekt igen genom `Push()-`metoden.
- [ ]  H�mta objekt med Peek-metoden:
    - [ ]  H�mta tv� objekt med `Peek()-`metoden.
    - [ ]  Efter varje rad eller element ska du skriva ut hur m�nga objekt som finns kvar i stacken.
- [ ]  Kolla om objekt nummer 3 finns i stacken eller inte och skriv ut resultatet.

![Output av Del 1 - Stack](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/7adac547-4fbd-4b1e-b983-a0663c6fff19/Capturegsgrg.png)

Output av Del 1 - Stack

## Del 2 � List

- [ ]  Skapa en List
- [ ]  L�gg in fem objekt av klassen `Employee` i din lista.
- [ ]  Skapa ett villkor med `Contains()-`metoden f�r att kolla om ett visst objekt finns i listan. Om det finns, skriv ut "Employee2 object exists in the list" i konsollen. Skriv annars ut "Employee2 object does not exist in the list".
- [ ]  Anv�nd sedan `Find()-`metoden f�r att hitta och skriva ut det f�rsta objektet i listan som har `Gender = "Male"`.
- [ ]  Anv�nd sedan `FindAll()-`metoden f�r att hitta och skriva ut alla objekt i listan som har `Gender = "Male"`

![Output av Del 2 - List](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/5fb05d32-92a2-4fe0-91d3-ae002318e8a9/assafs.png)

Output av Del 2 - List

# Din inl�mning

- Skicka in en l�nk till uppgiften i Canvas.
- Skicka in en textfil som inneh�ller l�nken till ett Github-repo med din kod.