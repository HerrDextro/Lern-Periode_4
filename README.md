# Lern-Periode 4

23.2 bis 5.4.2024

## Grob-Planung

1. Meine Noten sind nicht sehr gut, aber sie verbessern sich schon (Kanti Noten)
2. Ich wollte allgemein mehr programmieren
3. Ich möchte gerne ein dictionary (In diesem Fall ein Library) an mein NPC "AI" hinzufügen.
4. Tokenizer mit library

## 23.2.2024

Heute habe ich ein Tokenizer program, welche ich in meiner Freizet angefangen habe fertigprogrammiert. Das Ziel meines (einfachen) Tokenizers ist es nur, um sätze in einzelne Wörter umzuwandeln und auszugeben.
Es verwendet zur erkennung der Wörter eine Regex schema genutzt, welche einfach zusammensetzungen von charakteren zwischen zwei leerspalten als Wörter klassifiziert. Ich habe es getestet, indem ich ein paar Sätze im Diologfenster geschrieben habe, und dann der Output mit meinem Satz verglich.

## 30.2.2024

- [x] Tokenizer, welche einen Satz in einzelne Wörter umwandelt.
- [ ] "Word verifier" welcher dafür sorgt, dass nur echte wörter outputtet werden.
- [ ] Intent classifier, welcher die Wörter des Inputs mit die in der Library vergleicht, und ein Intent entscheidet.

|      Testfall-Nummer       |      Ausgangslage (Given)   |   Eingabe (When)   |    Ausgabe (Then)       | Erfüllt? |
|      ---------------       |      --------------------   |   --------------   |    --------------       | -------- |
|1 Tokenizer gibt wörter raus| Gibt einzelne wörter        | Hi my name is Neo  |Tokens: Hi my name is Neo|  Ja      |
|2                           |                             |                    |                         |          |
|4                           |                             |                    |                         |          |

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt



## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).
