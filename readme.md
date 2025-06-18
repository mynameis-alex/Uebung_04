# Übung 4

Die APK-Datei finden Sie im `Build`-Ordner.

Szenario:
- Museumsrundgang
-> Museum stellt geometrische Körper aus

Interface:
- Leaning
-> in zwei Achsen (vor/zurück, links/rechts)
-> sitzend auf drehbaren Stuhl

TO DO
- Controller sperren, sodass damit nicht navigiert werden kann
- smoothe Transferfunktion
  + Deadzone zu Beginn, wirkt auch wie Threshold, damit man nie perfekt auf (0, 0, 0) muss
  + maximaler Ausschlag
- Objekte + Wände platzieren
- Readme schreiben
- Erweiterung: mehrere Räume, die man via Teleportation erreichen kann



## Bewertung des Interfaces (Aufgabenteil B)

2 DOF -> Translation (x, z)

1 DOF -> Rotation (y)