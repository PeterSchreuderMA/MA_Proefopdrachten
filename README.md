# Custom Shaders

Hier komt een korte beschrijving van de proefopdracht. Wat heb je precies gedaan? 



## Features
Wanneer je een specifiek onderdeel wilt uitlichten kun je dat in deze sectie benoemen.

- De shader:
    -
    De bedoeling met de shader is dat ie de ['normals'](https://tinyurl.com/pcnesy2) van een 3D object met een 'amount' naar buiten kan trekken.
    Waardoor het lijkt dat het object dikker is.
    
    'Amount' 0%
    ![](https://docs.unity3d.com/560/Documentation/uploads/Main/SurfaceShaderDiffuseBump.png)
    
    'Amount' 50%
    ![](https://docs.unity3d.com/560/Documentation/uploads/Main/SurfaceShaderNormalExtrusion.png)
    
- Het eten:
    -    
    ![](https://assetstorev1-prd-cdn.unity3d.com/key-image/d4d10318-eb2f-4f66-8630-42bf6e208182.jpg)
        
    De bedoeling met het eten is dat de speler hierdoor slanker (gezond eten) of dikker (ongezond eten) word.
    En zo sneller kan rennen of beter koude tempraturen kan weerstaan.
    
    - Ik heb hiervoor nodig:
        -
        - Scriptable objects
        - Models


## Software Anaylse 
Welke software heb je voor deze proefopdracht onderzocht? En waarom heb je uiteindelijk gekozen voor de gekozen Software. Benoem hier specifieke argumenten.

- Bruikbare software
    -
    - Unity
    - Unreal
    - Shader graph voor Unity
    - JS TreeJs

- Wat ik ga gebruiken: Unity
    -
    
    - Waarom Unity?: 
        - 
        Unity die gebruikt C# en daar ben veel bekender mee dan C++. In Unity kan ik ook nog sneller en beter gameplay voor het spel bouwen. Kort gezegd, de code kan ik sneller schrijven dan in Unreal
    
    - Waarom geen Unreal?: 
        -
        Unreal heeft dat wel goede ondersteuning voor shaders en is ook gebouwd met het idee 
        dat het zware shaders moet runnen. Maar Het punt is dat ik te weinig van de code en UI in Unreal weet om er ook nog een speelbaar spel mee te crieeren.
    
        Het werkt ook nog eens met C++ waar ik te weinig van weet om voor de deadline iets mee te bouwen. 
        
        En Unreal crashed bij een fout pittig snel waardoor de ontwikkel tijd enorm vergroot. 
        
    - Waarom niet met Shader graph voor Unity?: 
        - 
        Shader Graph is dan wel een stuk makkelijker te gebruiken dan gewoon te werken met code. Maar ik wil erg graag weten hoe shaders zelf werken. En met een DnD systeem zou ik er een stuk moeilijker achter komen.
        
        Als ik het in code  


## Leerdoelen 
Wat wil je bereiken met dit project? Formuleer dit kort, krachtig en haalbaar.
https://www.desteven.nl/leerdoelen/smart-leerdoelen
Mijn motivatie achter waarom ik de opdracht heb gekozen

Hoe shader werken en hoe je dat kan implementeren

- 1: In eerste instantie wil ik een shader hebben die een object of karakter dikker kan maken met een slider.
- 2: Dan wil ik er een speel baar spelletje van maken. (Ik denk Agar.io style gameplay).
- 3: Dat je op basis van gezond blijven in het spel, punten behaald.
- 4: Elk eten object heeft z'n eigen stats als: Gezondheid rating, Calorien, Vet, Suiker. Dat gelijk staat aan: Uithouding & Energie.


## Planning 
Je hebt grofweg 2 weken, hoe deel je deze twee weken in. Wat plan je wanneer om precies te doen?

| | maandag | dinsdag | woensdag | donderdag | vrijdag |
| --- | --- | --- | --- | --- | --- |
|week 1 | Verdiepen Shaders | Implementatie Shaders & Gameplay bedenken | Scriptable Objects |  | Gameplay afronden | 
|week 2 | Polish | Speelbare versie op website | Deadline  |


## Bronnen
Welke bronnen heb je gebruikt? Zowel youtube filmpjes als artikelen

- Shaders:
    - 
    - [Shaders](https://www.youtube.com/watch?v=sXbdF4KjNOc)
    - [Surface shaders in Unity](https://docs.unity3d.com/560/Documentation/Manual/SL-SurfaceShaderExamples.html)
- Scriptable objects:
    -
    - [Scriptable Objects Video](https://www.youtube.com/watch?v=aPXvoWVabPY)
    - [Scriptable Objects Manual](https://docs.unity3d.com/Manual/class-ScriptableObject.html)