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
- weitere Objekte platzieren
- Readme schreiben
- Erweiterung: mehrere Räume, die man via Teleportation erreichen kann (=> Interaktion)
- Erweiterung: Sound, wenn man gegen etwas läuft ("Aua" für Feedback)

How to: Objekte platzieren
- Erstelle ein Objekt
- Verwende für das Objekt einen Collider (meist: Box/Capsule)
  + aktiviere "isTrigger"
  + vergrößere den Collider, sodass er (deutlich) über das Objekt hinausragt
- Sollte deine Figur aus mehreren Objekten bestehen, füge dem Eltern-Element einen Collider hinzu
  + entferne den Collider von allen Kindern



## Bewertung des Interfaces (Aufgabenteil B)

2 DOF -> Translation (x, z)

1 DOF -> Rotation (y)

Warum so implementiert?

Stärken & Schwächen?

Wie Nutzbarkeit & Performance messen?
-> Usability-Ziele (Welche sind erfüllt?)
