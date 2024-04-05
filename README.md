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
|1 Tokenizer gibt Wörter raus     | Gibt einzelne Wörter        | Hi my name is Neo  |Tokens: Hi               | ja       |
|2. WV findet die richtigen Wörter| bello=hello, musig=music    | I tinhk  wihch     |         my
|                                 |                             |                    |         name
|                                 |                             |                    |         is               
|                                 |                             |                    |         Neo             |          |
|2                                |                             |                    |                         |          |
|3                                |                             |                    |                         |          |

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




Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).
