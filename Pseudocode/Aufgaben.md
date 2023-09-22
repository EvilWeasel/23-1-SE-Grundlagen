# GA2 Winter 2020 Handlungsschritt 5

Frage Nutzer nach Eingabe von name
Frage Nutzer nach Eingabe von passwort

Falls name und passwort korrekt:
    Wahr: 
        Sende otp
        Frage Nutzer nach Eingabe von otp
        Falls onetimepassword korrekt:
            Wahr: Sende Nachricht "Willkommen"
            Falsch: Erneute Eingabeaufforderung
    Falsch: Erneute Eingabeaufforderung


# GA2 Sommer 2023 Handlungsschritt 4 a)

Initialisiere prescriptionColor mit dem Wert leer
Frage Nutzer nach insuranceType
Frage Nutzer nach medType

Prüfe insuranceType gleich "gesetzlich":
    Wahr: Prüfe medType gleich "verschreibungspflichtig":
        Wahr: Setze prescriptionColor gleich "rosa"
        Falsch:  Setze prescriptionColor gleich "grün"
    Falsch: Prüfe medType gleich "verschreibungspflichtig":
        Wahr: Setze prescriptionColor gleich "gelb"
        Falsch: Setze prescriptionColor gleich "blau"
Gebe prescriptionColor zurück.


# Aufgabe Factorial / Fakultät

Aufgabenstellung: Schreibe eine Funktion in Pseudocode, die die Fakultät einer gegebenen Zahl berechnet. 
	Die Fakultät einer Zahl n ist das Produkt aller positiven ganzen Zahlen von 1 bis n und wird als n! bezeichnet 
	(zum Beispiel: 5! = 5 × 4 × 3 × 2 × 1 = 120).
	(6! = 6 x 
        5 x 
        4 x 
        3 x 
        2 x 
        1)

	Die Funktion sollte einen Parameter haben, der die Zahl repräsentiert, für die die Fakultät berechnet werden soll.
	Die Funktion sollte die Fakultät dieser Zahl zurückgeben.

```csharp
decimal factorial(int 5) {...}
```

Pseudocode:

Lege den Wert von `n` fest auf Eingabe von Nutzer.
Lege Variable z als Zwischenergebnis fest. 0
Lege Variable i fest mit dem Wert 1;

Schleife bis i gleich n :
    Setze den Wert von zwischenergebnis auf den Wert von zwischenergebnis multipliziert mit `i`
    Erhöhe Wert von Variable `i` um 1
Gebe zwischenergebnis zurück

---

Param: Variable `n`
Setze Variable `i` auf den Wert `n`
Setze Variable ergebnis auf den wert von `n`

Schleife bis `i` gleich 1:
    Dekrement `i` um 1
    Setzte Wert von ergebnis auf Wert von ergebnis mal `i`

Gebe ergebnis zurück