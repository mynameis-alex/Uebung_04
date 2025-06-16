# Übung 3

Die APK-Dateien für beide Aufgaben finden Sie im `Build`-Ordner.

Verwenden Sie zur Navigation die üblichen Tasten. Alternativ können Sie sich auch im Raum bewegen.


## Aufgabe 3a

Oben links wird die Position des Nutzers als auch die Beschleunigung angegeben. Die Messung erfolgt via des XR-Rig-Objekts.

Oben rechts sind alle Kameras aufgelistet inklusive der relativen Winkel zum Nutzer.
Um weitere Kameras hinzuzufügen, muss die Vorlage der Tracker (TrackingCamera) lediglich dupliziert werden und hierarchisch dem leeren `Trackers`-Objekt direkt untergeordnet sein.



## Aufgabe 3b

Die Position des Nutzers wird anhand der Winkel zum Objekt von den Kamera-Objekten ausgehend berechnet.
Wie bei Aufgabe 3a können hier beliebig viele Kameras ergänzt werden.

Zum Tracking via der Kameras müssen mindestens zwei Kameras den Nutzer erfassen können. Kann eine Kamera
den Nutzer erfassen, leuchtet ihre Linse rot. Kann maximal eine Kamera den Nutzer erfassen, so wird anhand
der Beschleunigung versucht, die Positionsänderung des Nutzers zu ermitteln.

Zusätzlich gibt es ein akustisches Signal ("Disconnected."), wenn das Tracking via Kameras verloren geht.
Ist es ungenau, so wird ein Piepen abgespielt.

Die graue Kugel visualisiert die berechnete Position. Die genaue Position wird ebenfalls textuell angegeben.

Mit dem blauen Würfel kann interagiert werden, d.h. er kann gegriffen und bewegt werden.