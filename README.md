# Lern-Periode 4

23.2 bis 5.4.2024

## Grob-Planung

1. Meine Noten sind nicht sehr gut, aber sie verbessern sich schon (Kanti Noten)
2. Ich wollte allgemein mehr programmieren
3. Ich möchte gerne ein dictionary (In diesem Fall ein Library) an mein NPC "AI" hinzufügen.
4. Tokenizer mit library

## 23.2.2024

Heute habe ich ein Tokenizer Programm, welche ich in meiner Freizeit angefangen habe, so ungefähr fertigprogrammiert. Das Ziel meines (einfachen) Tokenizers ist es nur, um sätze in einzelne Wörter umzuwandeln und auszugeben.
Es verwendet zur erkennung der Wörter ein Regex Schema, welche einfach zusammensetzungen von charakteren zwischen zwei Leerspalten als Wörter klassifiziert. Ich habe es getestet, indem ich ein paar Sätze im Dialogfenster geschrieben habe, und dann der Output mit meinem Satz verglichen habe.

## 30.2.2024

- [x] Tokenizer, welche einen Satz in einzelne Wörter umwandelt.
- [ ] "Word verifier" welcher dafür sorgt, dass nur echte wörter outputtet werden.(Abbas schreibt eigentlich dieses Programm)
- [ ] Intent classifier, welcher die Wörter des Inputs mit die in der Library vergleicht, und ein Intent entscheidet.
- [ ] Library mit genug englishche Wörter um eine Konversation zu haben.

|      Testfall-Nummer            |      Ausgangslage (Given)   |   Eingabe (When)   |    Ausgabe (Then)       | Erfüllt? |
|      ---------------            |      --------------------   |   --------------   |    --------------       | -------- |
|1 Tokenizer gibt Wörter raus     | Gibt einzelne Wörter        | Hi my name is Neo  |Tokens: hi               | ja       |
|3                                |                             |                    |        my               |          |
|                                 |                             |                    |        name             |          |
|                                 |                             |                    |        is               |          |
|                                 |                             |                    |        neo              |          |
|                                 |                             |                    |                         |          |
|2. WV findet die richtigen Wörter| bello=hello, musig=music    | I tinhk  wihch     |  i think witch          | nein     |
|3. WV findet die richtigen Wörter| bello=hello, musig=music    | I tinhk  wihch     |  i think which          | ja       |

01.03.2024
Heute habe ich mein Tokenizer verbessert und ein Library-System für mein nächstes Programm entwickelt, der alle wörter Tags gibt und schlussendlich hoffentlich ein Paar tausend Wörter hat. Um es so gross zu machen wird ich ChatGPT eine englische Wörterliste Taggen lassen. Der nächste Schritt ist ein Entity-extractor, welche mit Regeln die Wörter als Entity klassifiziert oder als sonstiges, dafür greift es auf diesem Library zu.


## Arbeitspakete 29.03.2024 (frei) und 05.04.2024 

- [x] C# Data Libary (L1 ) erstellen
- [x] Data Libary L2 erstellen
- [ ] Intent classifier programmieren (Teil 1, Tokens mit L1 vergleichen, und dann alle mit _ verbinden)
- [ ] IC Teil 2, TokenTag_Token_Tag_TokenTag mit sentence syntax presets im L2 vergleichen, der meist ähniche wird gewählt, als output kommt er intent, welche mit der ausgewählte preset verknüpft ist raus.
- [ ] kleiner Debug Menu, aktiviert mit !debug, enthält !help list, dann !help (insert command). Commands werden für jetzt einfach: !verbose, !train, !logs


☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt



## Reflexion 29.03.2024
Abbas hat ein Word verifier programmiert, welche die Wörter von mein Tokenizer mit eine riesige Voki Liste vergleicht. Die Voki-Liste habe ich erstellt, aber sie hat noch nicht genug wörter um ohne einschränkungen genutzt zu werden (3000 wörter statt 8k oder so)Ich habe mit ihn zusammengearbeitet um ein Paar fehler wegzumachen, vor allem das Problem, dass das Programm ein Word nicht erneut verifiziert, wenn es ein zweites Mal im Satz vorkommt. Wir haben uns auch auf ein Format für die POS Tags in die Wörterliste geeinigt, und neue Listen in Excel erstellt. Die neue Liste hat fast alle wörter, die wir benötigen, aber es haben noch die Zeitformen der Verben gefehlt. 

## Reflexion 05.04.2024

Über die letzten paar Wochen habe ich eine grosse langfristiges Projekt mit Abbas Raza angefangen. 
Dieser Projekt soll über die nächsten paar Jahre dauern, meint Abbas, ich weiss es aber nicht. Unsere Idee wares, eine Art primitive KI zu programmieren, 
in dem das Programm durch preset satzstruktur syntaxes text verstehen kann, und mithilfe von komplizierte input output relation verbindungen einfache Antworten generiert. 
In dieser Lernperiode haben wir damit endlich angefangen.
Ich habe dafür ein Tokenizer und der Duden für die einfachen Wörter auf Englisch in Excel erstellt. 
Abbas hat begonnen mit ein Spellchecker / Word Identifier zu programmieren. 
Das Programm funktioniert indem es den Input Wort in der Wörterliste durchsucht und pro Wort (pro buchstabe eigentlich) einen Wert gibt als Nummer. 
Das Programm gibt aus der Wort am nächsten zum Input Wort. Der Spellckecker hat aber paar Falsche Ergebnisse. 
Aber es ist gut genug das man von einem Text Sinn daraus machen kann.
Das schwierige daran war das verstehen des Konzeptes und es in ein Programm umzuwandeln. 
Abbas habe viele Strategien benützt, dass der Programm ein möglichst richtiges Ergebnis ausgibt.
Der nächste Schritt ist alle Daten im Excel in SQL zu übertragen, weil wir haben gemerkt es einfacher ist alles einfacher zu verbinden. 
Nach dem wollen wir anfangen verschiedene Formen von Satz-Strukturen in SQL zu implementieren. (nur für Fragen gemeint.) 
Diese Satzstrukturen sind existieren dass der Programm identifizieren kann was für eine Frage gestellt wurde. 
Wir wollen die Grundlage des Konzepts kreieren. Das wollen wir in die nächste Lernperiode machen, als Projekt.
Das Projekt macht richtig Spass, und es motiviert mich, extra daran zu arbeiten, ich habe sogar in meine Freizeit daran gearbeitet, und Abbas und ich haben uns getroffen, um die nächsten Schritte zu Planen.
Dass es mehrere Jahren dauern wird glaube ich nciht wirklich, mit unsere aktuelle Geschwindigkeit wäre es noch irgenwann ende 2024/beginn 2025 komplett fertig
Die Zukunftige Teile des Programms werden auch ein bisschen komplizierter, aber da es so vielfältig ist gibt es Sachen die für mich eine Herausforderung wären, und für Abbas nicht, und auch Sachen die dann wieder für Abbas schwierig sind. Ich wurde dann Programme, die ein Input mit etwas in eine Excel datei vergleichen schreiben, und abbas könnte das Programm, das die Chancen von Intent/response "compatibility" berechnet schreiben oder so.


Hier ein Link zu Abbas sein repository, wo der Code sich befindet: https://github.com/Aboss3b13/Lernatelier_Lernperiode_-4
Ich hatte probleme mit das herunterladen des codes, und ich habe nur eine Outdatet Version hochgeladen.



Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).
