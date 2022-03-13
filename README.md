# Gruppe 6

## _Bedienung Prototyp_

Die ausführbare Datei RLWHR.exe und alles zugehörige befindet sich im Unterordner /UnityBuild  
Mit den beiden Sticks kann sich bewegt oder der Kamerawinkel auf der x-Achse verändert werden.  
Der Menü-Button ruft das Pausemenü auf.  
Solange der rechte Trigger-Button gehalten wird erhöht sich die Bewgungsgeschwindigkeit (Sprint).  
Sprünge sind mit dem Primär-Button möglich.  
Der Edding kann mit dem Grip-Button aufgehoben werden und bleibt solange in der Hand wie der Button gedrückt ist. (Tagging-Funktion im Build defekt, siehe Ende Abschnitt "Nikolai Kleinschmidt")  
Szene 0: Hauptmenü mit Hintergrundmusik (LoopTroop - Spraycan Stories)<br>
Szene 1: Hansaring, Einfahrt der Bahn. "Game Over" Screen erscheint wenn der/die Spieler/in nicht einsteigt.<br>
Szene 2: Bahnfahrt, Kontrolleur kommt auf Spieler/in zu, Dialogue und Szenenwechsel starten bei Kollision.<br>
Szene 3: Hauptbahnhof, Flucht vor Kontrolleur. Die Verzögerung bis der Kontrolleur in Szene 3 die Verfolgung aufnimmt ist auf 3 Sekunden eingestellt. "Game Over" Screen erscheint wenn der/die Spieler/in erwischt wird. "Escaped" Screen erscheint beim erreichen des Ziels (Cube mit Buchstaben Textur). Wählt man im "Escaped" Screen die Option "Explore" verschwindet der Kontrolleur und man kann sich noch in Ruhe umschauen bzw. Fangesänge anhören. <br> 


## _Ablaufplan_

[![](https://mermaid.ink/img/pako:eNptksFu2zAMhl-F0NkG7KTbwbcOWYEdAgwYetjgi2wxDhGZCiQaRVb0bfYMe4G-2GgoTto1BA-S-PPTT0HPpg8OTWMGyyItg4aQeIT72CFJsp230y4XnBV8CHG0AvBTo9xuy80m1xL2QoHhm0NkZHmi_uAnHnL1cUwov3Wbxte_g6d-f1A4MhDDI5Oc4BqNrQtYVau6rKuy1vW6cplyPyUkyw7jmQYjCTjFCPZ7Dj4MhHyBZEZdVjUUnxfG4vPiKB9_wYGYYauP4T0pOVMArmY0PxVwAf16otTvkY_x9U_Sge2MbT7oa_fugjfDNrNupe403w7ZKdZPKf0HvqjXdbFAv8cgQU5H2w22wwWoeXe9-AGJZyLtdrfGWxXXLrVxV91oe2f6RgfAYj3bsOtFsj6_wVmwhCnMiPqPyOnPe55rrZE9jtiaRpfOxkNrWn5R3XScf91XRxKiaSROWBg7Sfhx4n7ZZ82G7BDtaJqd9Qlf_gF80Nei)](https://mermaid.live/edit#pako:eNptksFu2zAMhl-F0NkG7KTbwbcOWYEdAgwYetjgi2wxDhGZCiQaRVb0bfYMe4G-2GgoTto1BA-S-PPTT0HPpg8OTWMGyyItg4aQeIT72CFJsp230y4XnBV8CHG0AvBTo9xuy80m1xL2QoHhm0NkZHmi_uAnHnL1cUwov3Wbxte_g6d-f1A4MhDDI5Oc4BqNrQtYVau6rKuy1vW6cplyPyUkyw7jmQYjCTjFCPZ7Dj4MhHyBZEZdVjUUnxfG4vPiKB9_wYGYYauP4T0pOVMArmY0PxVwAf16otTvkY_x9U_Sge2MbT7oa_fugjfDNrNupe403w7ZKdZPKf0HvqjXdbFAv8cgQU5H2w22wwWoeXe9-AGJZyLtdrfGWxXXLrVxV91oe2f6RgfAYj3bsOtFsj6_wVmwhCnMiPqPyOnPe55rrZE9jtiaRpfOxkNrWn5R3XScf91XRxKiaSROWBg7Sfhx4n7ZZ82G7BDtaJqd9Qlf_gF80Nei)

Evaluierung Zeitplan: Durch die klare Arbeitsaufteilung und das stetige weiterarbeiten konnten wir den Zeitplan gut einhalten. Trotz der erhöhten Arbeitsbelastung, dadurch, dass wir durch das Abspringen eines Kommilitonen nur zu zweit waren, war es uns möglich die anfänglichen Ideen gut umzusetzen.


## _Rollenverteilung_



Adriana Rieger (Modellierung und Organisation)
- Meine Hauptaufgabe besteht darin alle Objekte und NPCs zu modeln. Dafür habe ich mich mit [Blender](https://www.blender.org/) beschäftigt und damiteinhergehend mit dem fbx Export. Die NPCs der finalen Abgabe habe ich mit [Mixamo](https://www.mixamo.com/#/) erstellt. Hier habe ich unterschiedliche Charakter als fbx heruntergeladen und daraufhin in Blender alle Materials angepasst und das fertige Model in Mixamo animiert. Leider wurden die Animationen in Unity nicht übernommen und aus zeitlichen Gründen war eine intensivere Beschäftigung mit dem genauen Problem nicht gegeben. Jedes Modell/Objekt der Szenen wurde eigenständig mit Blender modelliert und nicht gekauft oder free gedownloadet. Die Models wurden groben Merkmalen der echten Umgebung angepasst. Einige Materials mussten in Unity angepasst und/oder ergänzt werden. Die Aufgaben der Organisation bestanden und bestehen in den Bereichen: Überblick behalten, Präsentationen vorbereiten, Zwischenziele setzen und dem "Dranbleiben".

Nikolai Kleinschmidt (scripting und Unity)
- Ich integriere die von Adriana erstellten Modelle in Unity und versuche unsere Vorstellung des Endprodukts so gut es geht umzusetzen. Ich benutze eine Kombination aus packages und plugins für VR Integration & Animation, die Scripts sind teilweise aus Tutorials mit Modifikationen für unser Projekt oder selbst geschrieben. Die in den Menüs verwendeten Grafiken stammen von der Website https://www.graffiti-empire.com/graffiti-generator/, die Audiodateien sind teilweise aus dem Internet und teilweise von mir vor Ort aufgenommen. Eine genaue Dokumentation meiner Arbeitsschritte findet sich in den GitHub-commits. Eine kleine Anmerkung von mir: aus irgendwelchen Gründen funktioniert das taggen nur im playmode des Unity Editors und nicht im finalen Build, ich habe wirklich extrem intensiv versucht diesen Fehler zu beheben aber leider ohne Erfolg. UPDATE: Nach Rücksprache mit einigen Personen in VR-Entwickler-Foren bin ich zwar dahinter gekommen was das Problem ist (ich verändere beim Taggen einzelne pixel der Texturen und diese sind im Build fest voreingestellt), einen komplett neuen Lösungsweg für die Umsetzung dieser Funktion zu finden ist leider zu zeitaufwändig geworden und ich habe die Lauffähigkeit des Projektes priorisiert. Unter dem Abschnitt Taggen habe ich allerdings ein .gif eingefügt wie die Funktion im Editor aussieht und ins Build hätte übernommen werden sollen.

## _Projektidee_
Im Sinne der im Modul vorhandenen Vorlesung "Media Transformation" haben wir uns für eine Geschichts-Ablaufs-basierte Umsetzung in Unity (VR) entschieden. Das bedeutet, das wir die chronologische Abfolge der erzählten Geschichte (Hansaring, S-Bahn, Hauptbahnhof, Breslauer Platz) übernommen haben, ebenso die Verfolgungsjagd zum Ende. Folgende Änderungen haben wir vorgenommen: 
- Reduzierung der interagierenden Personen (FAX'R, 1 Kontrolleur, Fans)
- Nicht dargestellten Umgebeung (wobei diese in der Geschichte keine Rolle spielt, aber intuitiv mitgedacht wird, wenn man die Gegend kennt)
- Der Spieler/ Die Spielerin erlebt das Geschehen aus der Sicht von FAX'R --> die Geschichte wird von BIKER TJARR erzählt. Dadurch ergibt sich die Möglichkeit die Geschichte aktiv miterleben zu können. 
- Der Spieler/ Die Spielerin kann mit einem Edding alles in seiner/ihrer Umgebung taggen

# Taggen
Durch das Taggen implementieren wir den persönlichen Hintergrund FAX'Rs in die Geschichte. Dadurch entsteht nicht nur durch die Transformation der Geschichte in VR ein neues Medium, sondern auch durch eine freie Entscheidungsmöglichkeit der Spielenden. Wie bereits oben erwähnt konnte dies Funktion leider nicht ins Build übernommen werden, hier aber ein .gif wie es ausgesehen hätte: https://media4.giphy.com/media/y19n9VdQZJdbuaiUiV/giphy.gif



# Entscheidungen
Abgesehen vom Taggen geben wir der Spielerin/dem Spieler die Möglichkeit selbst zu entscheiden wo sie/er entlangläuft um dem Kontrolleur am Hauptbahnhof zu entfliehen. Die Spielerin /der Spieler wird entdecken das einige Wege durch Hindernisse versperrt werden und erst einmal durch wiederholtes spielen eine mögliche Route zum Ziel herausfinden müssen.



