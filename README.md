# Gruppe 6

## _Bedienung Prototyp_

Die ausführbare Datei des Prototyps RLWHR.exe und alles zugehörige befindet sich im Unterordner /UnityBuild  
Mit den beiden Sticks kann sich bewegt oder der Kamerawinkel auf der x-Achse verändert werden.  
Der Menü-Button ruft das Pausemenü auf (mit dem die 2te Szene über den "Skip"-Button verlassen werden kann um zur 3ten Szene zu gelangen).  
Solange der rechte Trigger-Button gehalten wird erhöht sich die Bewgungsgeschwindigkeit (Sprint).  
Sprünge sind mit dem Primär-Button möglich.  
Der Edding kann mit dem Grip-Button aufgehoben werden und bleibt solange in der Hand wie der Button gedrückt ist. (Tagging-Funktion im Build defekt, siehe Ende Abschnitt "Nikolai Kleinschmidt")  
Die Verzögerung bis der Kontrolleur in Szene 3 die Verfolgung aufnimmt ist im Prototyp auf 10 Sekunden eingestellt.  


## _Ablaufplan_

[![](https://mermaid.ink/img/pako:eNptksFu2zAMhl-F0NkG7KTbwbcOWYEdAgwYetjgi2wxDhGZCiQaRVb0bfYMe4G-2GgoTto1BA-S-PPTT0HPpg8OTWMGyyItg4aQeIT72CFJsp230y4XnBV8CHG0AvBTo9xuy80m1xL2QoHhm0NkZHmi_uAnHnL1cUwov3Wbxte_g6d-f1A4MhDDI5Oc4BqNrQtYVau6rKuy1vW6cplyPyUkyw7jmQYjCTjFCPZ7Dj4MhHyBZEZdVjUUnxfG4vPiKB9_wYGYYauP4T0pOVMArmY0PxVwAf16otTvkY_x9U_Sge2MbT7oa_fugjfDNrNupe403w7ZKdZPKf0HvqjXdbFAv8cgQU5H2w22wwWoeXe9-AGJZyLtdrfGWxXXLrVxV91oe2f6RgfAYj3bsOtFsj6_wVmwhCnMiPqPyOnPe55rrZE9jtiaRpfOxkNrWn5R3XScf91XRxKiaSROWBg7Sfhx4n7ZZ82G7BDtaJqd9Qlf_gF80Nei)](https://mermaid.live/edit#pako:eNptksFu2zAMhl-F0NkG7KTbwbcOWYEdAgwYetjgi2wxDhGZCiQaRVb0bfYMe4G-2GgoTto1BA-S-PPTT0HPpg8OTWMGyyItg4aQeIT72CFJsp230y4XnBV8CHG0AvBTo9xuy80m1xL2QoHhm0NkZHmi_uAnHnL1cUwov3Wbxte_g6d-f1A4MhDDI5Oc4BqNrQtYVau6rKuy1vW6cplyPyUkyw7jmQYjCTjFCPZ7Dj4MhHyBZEZdVjUUnxfG4vPiKB9_wYGYYauP4T0pOVMArmY0PxVwAf16otTvkY_x9U_Sge2MbT7oa_fugjfDNrNupe403w7ZKdZPKf0HvqjXdbFAv8cgQU5H2w22wwWoeXe9-AGJZyLtdrfGWxXXLrVxV91oe2f6RgfAYj3bsOtFsj6_wVmwhCnMiPqPyOnPe55rrZE9jtiaRpfOxkNrWn5R3XScf91XRxKiaSROWBg7Sfhx4n7ZZ82G7BDtaJqd9Qlf_gF80Nei)

Wir befinden uns bei dem roten Strich. Die nächsten Steps sind die Feinjustierungen bezüglich 1. der Modellierung (Texturierung und Detailarbeit, sowie der Hansaring) und 2. Das fertige Gameplay in Unity.


## _Rollenverteilung_



Adriana Rieger (Modellierung und Organisation)
- Meine Hauptaufgabe besteht darin alle Objekte und NPCs zu modeln. Dafür habe ich mich mit [Blender](https://www.blender.org/) beschäftigt und damiteinhergehend mit dem fbx Export. Für die NPC habe ich den [Character Creator](https://www.reallusion.com/character-creator/) verwendet, werde mich aber für den weiteren Verlauf und die Möglichkeit auf mehr Deteils mit weiteren Tools auseinandersetzen. Jedes Modell/Objekt wurde selbst modelliert und nicht gekauft oder free gedownloadet. Die Aufgaben der Organisation bestanden und bestehen in den Bereichen: Überblick behalten, Präsentationen vorbereiten, Zwischenziele setzen und dem "Dranbleiben".

Nikolai Kleinschmidt (scripting und Unity)
- Ich arbeite mit den von Adriana erstellten Modellen in Unity um unsere Vorstellung des Endprodukts so gut es geht umzusetzen. Ich benutze eine Kombination aus packages und plugins für VR Integration & Animation, die Scripts sind teilweise aus Tutorials mit Modifikationen für unser Projekt oder handgeschrieben.  Eine genaue Dokumentation meiner Arbeitsschritte findet sich in den GitHub-commits. Eine kleine Anmerkung von mir: aus irgendwelchen Gründen funktioniert das taggen nur im playmode des Unity Editors und nicht im finalen Build, ich habe die letzten Tage wirklich extrem intensiv versucht diesen Fehler zu beheben aber bisher leider ohne Erfolg. Vielleicht springt Ihnen ja ein fataler Fehler ins Auge an dem es liegen könnte.

## _Projektidee_
Im Sinne der im Modul vorhandenen Vorlesung "Media Transformation" haben wir uns für eine Geschichts-Ablaufs-basierte Umsetzung in Unity (VR) entschieden. Das bedeutet, das wir die chronologische Abfolge der erzählten Geschichte (Hansaring, S-Bahn, Hauptbahnhof, Breslauer Platz) übernommen haben, ebenso die Verfolgungsjagd zum Ende. Folgende Änderungen haben wir vorgenommen: 
- Reduzierung der interagierenden Personen (FAX'R, 1 Kontrolleur, Fans)
- Nicht dargestellten Umgebeung (wobei diese in der Geschichte keine Rolle spielt, aber intuitiv mitgedacht wird, wenn man die Gegend kennt)
- Der Spieler/ Die Spielerin erlebt das Geschehen aus der Sicht von FAX'R --> die Geschichte wird von BIKER TJARR erzählt. Dadurch ergibt sich die Möglichkeit die Geschichte aktiv miterleben zu können. 
- Der Spieler/ Die Spielerin kann mit einem Edding alles in seiner/ihrer Umgebung taggen

# Taggen
Durch das Taggen implementieren wir den persönlichen Hintergrund FAX'Rs in die Geschichte. Dadurch entsteht nicht nur durch die Transformation der Geschichte in VR ein neues Medium, sondern auch durch eine freie Entscheidungsmöglichkeit der Spielenden. 
# Entscheidungen
Abgesehen vom Taggen geben wir der Spielerin/dem Spieler die Möglichkeit selbst zu entscheiden wo sie/er entlangläuft um dem Kontrolleur am Hauptbahnhof zu entfliehen. Die Spielerin /der Spieler wird entdecken das einige Wege durch Hindernisse versperrt werden und erst einmal durch wiederholtes spielen eine mögliche Route zum Ziel herausfinden müssen.



