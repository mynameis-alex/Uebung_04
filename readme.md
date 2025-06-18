# Übung 4

Die APK-Datei finden Sie im `Build`-Ordner.

Szenario:
- Museumsrundgang
-> Museum stellt geometrische Körper aus

Interface:
- Leaning
-> in zwei Achsen (vor/zurück, links/rechts)
-> sitzend auf drehbaren Stuhl

- Initiale Position speichern
-> Richtungsvektor berechnen zwischen aktueller Position und initialer Position
  -> Richtungsvektor-y auf initiale Höhe setzen, damit die Höhe immer gleich bleibt
  -> alte Position + (Richtungsvektor * Beschleunigungsfaktor der Transferfunktion) = neue Position
  -> wir bewegen das Museum statt uns, damit wir die initiale Position nicht neu berechnen müssen
    -> Werte müssen umgekehrt werden



## Bewertung des Interfaces (Aufgabenteil B)

2 DOF -> Translation (x, z)

1 DOF -> Rotation (y)