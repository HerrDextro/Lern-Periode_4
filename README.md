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

|      Testfall-Nummer       |      Ausgangslage (Given)   |   Eingabe (When)   |    Ausgabe (Then)       | Erfüllt? |
|      ---------------       |      --------------------   |   --------------   |    --------------       | -------- |
|1 Tokenizer gibt Wörter raus| Gibt einzelne Wörter        | Hi my name is Neo  |Tokens: Hi               | ja       |
|                            |                             |                    |         my
|                            |                             |                    |         name
|                            |                             |                    |         is               
|                            |                             |                    |         Neo             |          |
|2                           |                             |                    |                         |          |
|3                           |                             |                    |                         |          |

01.03.2024
Heute habe ich mein Tokenizer verbessert und ein Library-System für mein nächstes Programm entwickelt, der alle wörter Tags gibt und schlussendlich hoffentlich ein Paar tausend Wörter hat. Um es so gross zu machen wird ich ChatGPT eine englische Wörterliste Taggen lassen. Der nächste Schritt ist ein Entity-extractor, welche mit Regeln die Wörter als Entity klassifiziert oder als sonstiges, dafür greift es auf diesem Library zu.


## Arbeitspakete 29.03.2024 (frei) und 05.04.2024 

- [ ] C# Data Libary (L1 ) erstellen
- [ ] Data Libary L2 erstellen
- [ ] Intent classifier programmieren (Teil 1, Tokens mit L1 vergleichen, und dann alle mit _ verbinden)
- [ ] IC Teil 2, TokenTag_Token_Tag_TokenTag mit sentence syntax presets im L2 vergleichen, der meist ähniche wird gewählt, als output kommt er intent, welche mit der ausgewählte preset verknüpft ist raus.
- [ ] kleiner Debug Menu, aktiviert mit !debug, enthält !help list, dann !help (insert command). Commands werden für jetzt einfach: !verbose, !train, !logs


☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt



## Reflexion[Uploading NLP_V1_Model.drawio…]()<mxfile host="Electron" modified="2024-02-23T20:31:22.098Z" agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) draw.io/23.1.5 Chrome/120.0.6099.109 Electron/28.1.0 Safari/537.36" etag="Od474EbXfDiANGp-Ezsa" version="23.1.5" type="device">
  <diagram name="Page-1" id="2YBvvXClWsGukQMizWep">
    <mxGraphModel dx="2069" dy="1822" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="850" pageHeight="1100" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-11" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="295" y="470" width="235" height="400" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-6" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="295" y="90" width="230" height="270" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-1" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="330" y="150" width="160" height="80" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-2" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Tokenizer&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="330" y="155" width="160" height="70" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-3" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="327.5" y="257.5" width="165" height="80" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-4" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="409.5" y="230" as="sourcePoint" />
            <mxPoint x="410" y="260" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-5" value="&lt;span style=&quot;font-size: 14px;&quot;&gt;Word verifier&lt;/span&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="362.5" y="280" width="95" height="35" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-7" value="&lt;font style=&quot;font-size: 15px;&quot;&gt;Text recognition module&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="325" y="100" width="170" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-8" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;endWidth=55;endSize=7.07;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="409.5" y="360" as="sourcePoint" />
            <mxPoint x="409.5" y="400" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-9" value="&lt;span style=&quot;font-size: 14px;&quot;&gt;tokenized input text&lt;/span&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="330" y="400" width="160" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-10" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;endWidth=55;endSize=7.07;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="409.5" y="430" as="sourcePoint" />
            <mxPoint x="409.5" y="470" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-12" value="&lt;font style=&quot;font-size: 15px;&quot;&gt;Intent classification and Entity extraction&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="325" y="480" width="170" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-32" value="" style="rounded=1;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="321.5" y="510" width="173.5" height="200" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-13" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="332.5" y="530" width="150" height="70" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-15" value="" style="shape=flexArrow;endArrow=classic;startArrow=classic;html=1;rounded=0;" edge="1" parent="1">
          <mxGeometry width="100" height="100" relative="1" as="geometry">
            <mxPoint x="482.5" y="660" as="sourcePoint" />
            <mxPoint x="650" y="660" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-16" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="650" y="565" width="250" height="220" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-18" value="&lt;font style=&quot;font-size: 15px;&quot;&gt;Library 1&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="720" y="575" width="110" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-19" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Contains Vocabulary, all tagged, acts as POS tagger&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="685" y="645" width="180" height="60" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-20" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="335" y="625" width="150" height="70" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-14" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Intent classifier&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="357.5" y="645" width="100" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-21" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Entity extractor&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="358.25" y="550" width="100" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-23" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;exitX=0;exitY=0.5;exitDx=0;exitDy=0;entryX=0.5;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="EpPh9EG6Jb95I4vqG8Gm-13" target="EpPh9EG6Jb95I4vqG8Gm-24">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="120" y="610" as="sourcePoint" />
            <mxPoint x="110" y="660" as="targetPoint" />
            <Array as="points">
              <mxPoint x="55" y="565" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-24" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="-70" y="605" width="250" height="220" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-25" value="&lt;font style=&quot;font-size: 15px;&quot;&gt;Library 2&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry y="615" width="110" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-26" value="&lt;span style=&quot;font-size: 14px;&quot;&gt;Saves important entities&lt;br&gt;Saves the Context and Intent&lt;br&gt;Contains all possible intents&lt;br&gt;&lt;/span&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="-35" y="685" width="180" height="60" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-29" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;endWidth=55;endSize=7.07;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="407" y="710" as="sourcePoint" />
            <mxPoint x="407" y="750" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-31" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="317.5" y="750" width="180" height="100" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-33" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Context handler&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="340" y="780" width="140" height="40" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-34" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;endWidth=55;endSize=7.07;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="407" y="870" as="sourcePoint" />
            <mxPoint x="407" y="910" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-35" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="220" y="910" width="380" height="150" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-36" value="&lt;font style=&quot;font-size: 15px;&quot;&gt;Response generator&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="312.5" y="920" width="180" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-37" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="650" y="875" width="250" height="220" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-38" value="&lt;font style=&quot;font-size: 15px;&quot;&gt;Library 3&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="720" y="885" width="110" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-39" value="&lt;span style=&quot;font-size: 14px;&quot;&gt;Contains preset sentence templates, both for input and output intents&lt;/span&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="685" y="955" width="180" height="60" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-40" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="650" y="984.5" as="sourcePoint" />
            <mxPoint x="600" y="985" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-41" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;endWidth=55;endSize=7.07;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="412" y="1060" as="sourcePoint" />
            <mxPoint x="412" y="1100" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-42" value="&lt;font size=&quot;1&quot; style=&quot;&quot;&gt;&lt;b style=&quot;font-size: 40px;&quot;&gt;Output&lt;/b&gt;&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="340" y="1110" width="145" height="60" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-43" value="&lt;font size=&quot;1&quot; style=&quot;&quot;&gt;&lt;b style=&quot;font-size: 40px;&quot;&gt;Input&lt;/b&gt;&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="335" y="-10" width="145" height="60" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-44" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;endWidth=55;endSize=7.07;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="407" y="50" as="sourcePoint" />
            <mxPoint x="407" y="90" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-46" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;exitX=0;exitY=0.75;exitDx=0;exitDy=0;entryX=0.917;entryY=-0.028;entryDx=0;entryDy=0;entryPerimeter=0;" edge="1" parent="1" source="EpPh9EG6Jb95I4vqG8Gm-16" target="EpPh9EG6Jb95I4vqG8Gm-35">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="570" y="850" as="sourcePoint" />
            <mxPoint x="620" y="800" as="targetPoint" />
            <Array as="points">
              <mxPoint x="568" y="730" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-47" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;" edge="1" parent="1" target="EpPh9EG6Jb95I4vqG8Gm-31">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="180" y="770" as="sourcePoint" />
            <mxPoint x="230" y="860" as="targetPoint" />
            <Array as="points">
              <mxPoint x="230" y="770" />
              <mxPoint x="280" y="800" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-49" value="" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="-100" y="875" width="250" height="220" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-50" value="&lt;font style=&quot;font-size: 15px;&quot;&gt;Library 4&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="-30" y="885" width="110" height="30" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-51" value="&lt;span style=&quot;font-size: 14px;&quot;&gt;Contains Intent associations&lt;/span&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="-65" y="955" width="180" height="60" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-53" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;" edge="1" parent="1" source="EpPh9EG6Jb95I4vqG8Gm-49" target="EpPh9EG6Jb95I4vqG8Gm-35">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="200" y="950" as="sourcePoint" />
            <mxPoint x="217" y="960" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-54" value="" style="shape=flexArrow;endArrow=classic;startArrow=classic;html=1;rounded=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;exitX=1;exitY=0.25;exitDx=0;exitDy=0;" edge="1" parent="1" source="EpPh9EG6Jb95I4vqG8Gm-24" target="EpPh9EG6Jb95I4vqG8Gm-20">
          <mxGeometry width="100" height="100" relative="1" as="geometry">
            <mxPoint x="190" y="730" as="sourcePoint" />
            <mxPoint x="290" y="630" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-55" value="&lt;font style=&quot;&quot;&gt;&lt;b style=&quot;&quot;&gt;&lt;font style=&quot;font-size: 17px;&quot;&gt;NOTE&lt;/font&gt;&lt;/b&gt;&lt;span style=&quot;font-size: 15px;&quot;&gt;: For Debug purposes: every stage gives an Input to the ADMIN block, and the ADMIN block can send an Input to any module in the system bypassing all others&lt;/span&gt;&lt;/font&gt;" style="text;html=1;align=center;verticalAlign=middle;whiteSpace=wrap;rounded=0;" vertex="1" parent="1">
          <mxGeometry x="-50" y="270" width="280" height="220" as="geometry" />
        </mxCell>
        <mxCell id="EpPh9EG6Jb95I4vqG8Gm-56" value="" style="shape=flexArrow;endArrow=classic;html=1;rounded=0;exitX=1;exitY=1;exitDx=0;exitDy=0;entryX=0;entryY=0;entryDx=0;entryDy=0;" edge="1" parent="1" source="EpPh9EG6Jb95I4vqG8Gm-24" target="EpPh9EG6Jb95I4vqG8Gm-35">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="460" y="710" as="sourcePoint" />
            <mxPoint x="510" y="660" as="targetPoint" />
          </mxGeometry>
        </mxCell>
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>



Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).
