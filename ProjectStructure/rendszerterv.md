
# Zoknipárosító Webalkalmazás Rendszerterve

## Architektúra
**A fejlesztés során az OOP (Objektum Orientált Programozás) alapelveinek megfelelően kell eljárni.**


Az alkalmazás egy háromrétegű architektúrával fog működni:

1. **Felhasználói réteg (Presentation Layer)**: Ez a réteg felelős a felhasználói interfész megjelenítéséért és a felhasználói interakciók kezeléséért. Az ASP.NET webalkalmazás lesz felelős a felhasználói felület megjelenítéséért és a kliensoldali logika végrehajtásáért.

2. **Üzleti réteg (Business Layer)**: Ez a réteg tartalmazza az alkalmazás üzleti logikáját és az adatfeldolgozást. Ide tartoznak a játékmenet vezérlése, a leaderboard kezelése és a felhasználók játékadatainak logikája.

3. **Adatbázis réteg (Data Layer)**: Az adatbázis rétegben található az SQL adatbázis, amely tárolja a felhasználók játékadatait és a játék eredményeit.

### Architekturális terv

![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/Architekturális%20terv.png)

## Üzleti folyamatok modell

![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/üzleti%20folyamatok.png)

## Adatbázis

Az alkalmazás egy SQL adatbázist használ a felhasználói adatok és a játék eredményeinek tárolására. Az adatbázis tartalmazza a következő táblákat:

1. **leaderboard**: Ebben a táblában rögzítjük a játékosok játék eredményeit, beleértve a játékos nevét, a pontszámát, a nehézségi fokozatot és a játék dátumát.
2. **zokni**: Ebben a táblában rögzítjük a különböző zokinik modelljét, amelyeket ellátunk egy id-val is és nehézségi szinttel is. A játék betöltésekor innen nyerjük ki véletlenszerűen a bizonyos nehézségi szinthez járó zoknik számát és nehézségi szintjét.
3. **palyak**: A Pályák nevű táblában tároljuk a pálya nevét, nehézségét és az időkorlátot amely alatt teljesíteni kell a megadott pályát.

### DatabaseService() 
Ezt az osztályt is az Objektum orientált programozás elvei alapján kell létrehozni.
#### Ez felel:
- Az adatbázishoz való csatlakozásért
- Sikeres kapcsolat felállítása
- Az SQL lekérdezésekért
- Az SQL parancsok futtatásáért


### Adatbázis modell terv

![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/adatbazis_kep_zokni.png)

Az adatbázis modell elég egyszerű, mivel a játék gyermekeknek készült így a komplexitása limitált. Az adatbázisban tároljuk a zoknik id-ját és azt, hogy melyik nehézségi fokozathoz tartoznak.

A játék során a megadott játékelemeket az adatbázis redundancia nélkül kezeli, ezzel hozzájárulva a gyorsabb futáshoz, kevesebb hardware igényhez és a skálázhatósághoz.

Az adatbázisban emellett a játékosok Leadboard (eredményekk) adatait is tároljuk. A tábla tartalmazza a játékos felhasználónevét, a játék dátumát, nehézségi szintjét és a játék idejét is. 

### Assetek létrehozása (Játékelemek)
A játékelemeket Adobe Illustrator-ban hozzuk létre .svg kiterjesztésben, ami vektorgrafikus képábrázolást jelent. A vektorgrafikus képábrázolás előnyei a következők a mi esetünkben:
- A képek mindig élesek lesznek attól függetlenül, hogy milyen felületen játszik a játékos
- A képeket könnyű módosítani
- A képek nem torzulnak el a megjelnítő felület változásától. (Pl. Ha nem teljes képernyőn játszik a játékos, akkor a játékelemek idomulnak a megjelenítő eszköz méretéhez.)

#### Assetek kinézete
![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/asset_kinezet.png)

## Felhasználói Interfész

Az alkalmazás webes felhasználói felületet használ, amely HTML, CSS és JavaScript segítségével van megvalósítva. A felhasználói interfész tartalmazza a következő oldalakat és elemeket:


1. **Főoldal**: A főoldalon jelenik meg a menü ahol a játékos kiválaszthatja a játék nyelvét (Magyar/Angol), a játék nehézségét (Könnyű, Közepes, Nehéz) és itt tekintheti meg a Leaderboardot is.

2. **Játékterület**: A játékterületen jelennek meg a zoknik, és itt zajlik a játék. A játéktér tetején jelenik meg a számláló.

3. **Leaderboard**: A leaderboard oldalon láthatók a legjobb pontszámok és a játékosok nevei.

## Backend Fejlesztés
A backend fejlesztés során a .NET Core keretrendszert használjuk, amely lehetővé teszi a könnyű és hatékony fejlesztést, valamint a webalkalmazásunk könnyű telepítését és kezelését. A .NET Core alkalmazás tartalmazza az üzleti logikát, a játékmenet vezérlését, a leaderboard kezelését és az adatbázis kapcsolatot.

A fejlesztés során kifejezett figyelmet kell fordítani a skálzhatóságra és az adatbázis agilis működésére.

**A fejlesztés követi az MVC fejlesztési konvenciót!**

![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/MVC_Ajax.png)

#### Használandó technológiák
 
- Adatbázis típus és verzió: MariaDB 
- - MariaDB 10.8.28
- - Webkiszolgáló: Apache 2.4.56
- - PHP Myadmin 5.2.1
- Adatbázis tervezés: DBForge Studio
- Helyi adatbázis futtatása: Xampp


### DatabaseService osztály 
Ezt az osztályt is az Objektum orientált programozás elvei alapján kell létrehozni.
#### Ez felel:
- Az adatbázishoz való csatlakozásért
- Sikeres kapcsolat felállítása
- Az SQL lekérdezésekért
- Az SQL parancsok futtatásáért

### Modell
Létre kell hozni a táblák modelljét. A fejlesztés C#-ban történik. Amelyeknek pontosan illeszkednie kell az adatbázisban tárolt adatokhoz. (típusegyezés feltétel)
Adatelérés és üzleti logika: A modell felelős az alkalmazás adatelérési rétegének és üzleti logikájának implementálásáért. Ez lehetővé teszi az adatok kezelését, lekérdezését, módosítását és validálását.
Entitások és adatok reprezentálása: A modell definiálja az alkalmazásban használt entitásokat és adatszerkezeteket. Ezek az entitások tükrözik az alkalmazásban kezelt adatokat, és gyakran a példányok (objektumok) formájában vannak jelen, amelyek adatait az adatbázisból vagy más forrásokból töltik be.

### Controller
A controllerből kell meghívni az oldalakat. A View-t ezzel jelenítjük meg. Itt kell létrehozni az SQL lekérdezéseket(SELECT) illetve a SQL INSERT-eket. A parancsok itt kerülnek létrehozásra. 

HTTP kérések kezelése: A Controller fogadja és kezeli az HTTP kéréseket, amelyek érkeznek a webalkalmazásba. Ezek a kérések lehetnek például GET, POST, PUT vagy DELETE kérések, és különböző útválasztásokhoz és akciókhoz vezetnek.

Nézetek megjelenítése: A Controller felelős a nézetek (View) kiválasztásáért és megjelenítéséért. A nézetek tartalmazzák az oldalak HTML kódját és az adatok megjelenítéséhez szükséges elemeket. A Controller által választott nézetek a kliens böngészőjében jelennek meg.

Üzleti logika: A Controller tartalmazhat üzleti logikát, amelyet végrehajt a HTTP kérés kezelése során. Ez magában foglalhatja az adatbázisból adatok lekérdezését, feldolgozását, validálását és más műveleteket, amelyek szükségesek a kérés feldolgozásához.

Modellel való kommunikáció: A Controller kapcsolatot teremt a Model (modell) réteggel, és az Model rétegből származó adatokat használja a nézetekben való megjelenítéshez vagy az üzleti logika végrehajtásához. Ezenkívül a Controller felelős az adatokat a Model rétegbe való visszairányításáért.

HTTP válaszok létrehozása: A Controller létrehozza az HTTP válaszokat, amelyeket a szerver küld a kliensnek. Ezek a válaszok tartalmazhatnak HTML oldalakat, JSON adatokat vagy más típusú válaszokat, például fájlokat.

Útválasztás és útvonalvezérlés: A Controller dönti el, hogy melyik akciót hajtja végre egy adott HTTP kérés. Az útvonalvezérlés (routing) segítségével az alkalmazás meghatározza, hogy melyik Controller és akció felel meg a beérkező kérésnek.

HTTP kérés paraméterek kezelése: A Controller fogadja és kezeli az HTTP kérések paramétereit, például az URL-ben vagy a HTTP testben található adatokat. Ezek a paraméterek segítenek az akciók személyre szabásában és az adatok feldolgozásában.

Összességében a Controller a központi elem az MVC modellben, amely összekapcsolja a felhasználói felületet (View) az alkalmazás logikájával és az adatokkal (Model). Felelős az HTTP kérések feldolgozásáért, az üzleti logika végrehajtásáért és a megfelelő válaszok létrehozásáért a kliensnek.

#### - Ajax hívások
**Jquerry** segítségével Ajax hívásokat küldünk a Controller megfelelő metódusaira. Ezek lehetnek **GET** Illetve **POST** hívások. Itt tudunk adatot irányítani a View és a Controller között. Kifejezetten JSON-ben várjuk az adatokat. 

Az Ajax hívások a webes alkalmazásokban lehetővé teszik aszinkron kérések küldését a kliens és a szerver között anélkül, hogy a teljes oldalfrissítést kellene végrehajtani. A jQuery segítségével könnyedén kezelhetjük ezeket a kéréseket, és adatokat küldhetünk a Controller metódusaihoz. Itt van néhány további információ az Ajax hívásokról és a JSON adatkommunikációról:

Aszinkron kommunikáció: Az Ajax hívások lehetővé teszik a böngésző és a szerver közötti aszinkron kommunikációt. Ez azt jelenti, hogy a felhasználó továbbra is használhatja az alkalmazást, miközben a háttérben adatokat kér le vagy küld.

GET és POST kérések: Az Ajax hívások lehetnek GET vagy POST kérések. A GET kérések általában adatok lekérdezésére szolgálnak a szerverről, míg a POST kérések adatok küldésére a szervernek.

JSON adatok: Az Ajax hívások általában JSON (JavaScript Object Notation) formátumban küldik és fogadják az adatokat. Ez egy könnyen olvasható és írható adatformátum, amely jól alkalmazható a kliens és a szerver közötti adatkommunikációra.

Adatok irányítása a Controller és a View között: Az Ajax hívások lehetővé teszik az adatok irányítását a Controller és a View között. A kliens oldali JavaScript segítségével készíthetünk HTTP kéréseket a Controller metódusaihoz, majd a Controller válaszaként kapott adatokat beállíthatjuk vagy megjeleníthetjük a View-ban.

Dinamikus frissítések: Az Ajax hívások segítségével dinamikus frissítéseket hajthatunk végre a weboldalon anélkül, hogy az egész oldalt újratöltenénk. Például egy űrlap elküldése után azonnal megjeleníthetjük a választ a felhasználónak a Controller válaszaként.

Az Ajax hívások hasznosak olyan helyzetekben, amikor a felhasználói interakciók során szükség van az oldal tartalmának frissítésére vagy adatok dinamikus lekérdezésére a szerverről anélkül, hogy a teljes oldalt újratöltenénk. Ez növelheti az alkalmazás teljesítményét és interaktivitását. Az adatok JSON formátumban történő használata lehetővé teszi az egyszerű és hatékony adatkommunikációt a kliens és a szerver között.

### View 
A View-ról részletesebben a [Frontend Fejlesztés](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/rendszerterv.md#frontend-fejlesztés)-ben olvashat!


### AppSettings.json
Ebben a .json fájlban tároljuk el a *SQL connection* stringet, amit a DB service felhasznál a kapcsolat kiépítése érdekében. 
Az appsettings.json egy JSON-formátumú konfigurációs fájl, amelyet gyakran használnak ASP.NET Core alkalmazásokban a beállítások és konfigurációk tárolására. A fájl tartalmazza az alkalmazás különböző részeihez kapcsolódó beállításokat, például adatbázis kapcsolatokat, naplózási szinteket, engedélyezett hosztokat és egyéb konfigurációs adatokat.

Ez a fájl segít az alkalmazás konfigurálásában és testreszabásában anélkül, hogy a forráskódot módosítanánk. Az alkalmazások gyakran használják, hogy eltérő beállításokat használjanak különböző környezetekben, például fejlesztés, tesztelés vagy élesítés közben.

Az appsettings.json fájlt a .NET Core alkalmazásokban használják, és a .NET Core konfigurációs rendszerrel van integrálva. Az alkalmazások ebből a fájlból olvassák ki a konfigurációt, amelyet aztán felhasználhatnak az alkalmazás működésének szabályozására. A fájlban található beállításokat könnyű módosítani, ami lehetővé teszi az alkalmazás viselkedésének rugalmas testreszabását.


### Program.cs
Az ASP .net Core belépési pontja, és inicializálja az alkalmazás szolgáltatásait beállítja a konfigurációt és konfigurálja a HTTP kérési feldolgozást az alkalmazásban. 


## Frontend Fejlesztés
A frontend fejlesztés során HTML, CSS és JavaScript nyelveket használjnuk. Ezek a technológiák lehetővé teszik a modern és reszponzív felhasználói felület kialakítását. A felhasználói felület elemeket, például a játékterületet és a menüt HTML és CSS segítségével hozzuk létre és formázzuk meg, míg a kliensoldali logika és interakciókat JavaScript segítségével valósítjuk meg.

A felhasználói felület fejlesztése során kifejezett figyelmet kell fordítani a reszopnzív web design (CSS Media Queries) alapelveinek betartására. Részletesebben a reszponzivitásról [ITT](https://www.w3schools.com/css/css_rwd_mediaqueries.asp) olvashatsz.

### Menü terv:
![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/menu_frontend_terv.png)

### Játék terv:
![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/jatek_frontend_terv.png)

### Leaderboard terv
![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/leaderboard_frontend_terv.png)

## Bootstrap

## Javascript
A játék mechanikáját itt hozzuk létre. Tárolja az AJAX hívásokat. Kigenerálja a játékfelületre az AJAX hívásokból kapott információkat és megjeleníti a játékos számára.

A Leaderboardban egy **for** ciklus segítségével ki kell generálni és megjeleníteni az adatot.

Az index oldalokon a játékosnév hiányát itt kell lekezelni a nehézségi fokozat választás mellett. A játék addig nem indulhat el míg a játékos nem választ fokozatot és nem ad meg egy felhasználónevet (Játékosnevet). A program hibaüzenetet kell, hogy visszadobjon ha ezeknek a feltételeknek nem tesz eleget.

A játékost a kiválasztott nehézségi szint alapján elnavigáljuk az ahhoz korreszpondáló pályához. 

#### Játék
A fentebb kiválasztott nehézségi fokozat alapján meghívjuk a hozzá tartozó AJAX hívást az adott szinthez tartozó játékelemek kigenerálásához és megjelenítéséhez. 
A játék mechanizmusáért a Javascript elem felel. A .js fájlban van eltárolva a párosztatási mechanizmus is.

A játék végén meghívjuk azt az AJAX hívást, amivel eltároljuk az adott játék és játékos játékadatait. (Név, nehézség, idő)


### Áttekintés
Bootstrap egy népszerű, nyílt forráskódú CSS és JavaScript keretrendszer, amelyet a Twitter fejlesztett ki. Ez egy olyan eszköz, amely lehetővé teszi a gyors és egyszerű webes alkalmazások és weboldalak fejlesztését, anélkül, hogy az összes stílust és interakciót teljesen nulláról kellene létrehozni.

### Bootstrap használata a Felhasználói Interfész fejlesztésében

Az alkalmazás felhasználói interfészének fejlesztése során a Bootstrap keretrendszert alkalmazzuk az alábbi módon:

- HTML és CSS: Bootstrap beillesztése a projektünk HTML és CSS fájljaiba egyszerű. Az előre elkészített CSS osztályokat és komponenseket egyszerűen hozzáadhatjuk az HTML elemekhez, így könnyen formázhatjuk azokat.

- Responszív design: Bootstrap segítségével könnyen kialakíthatjuk az alkalmazásunk responszív designját. Az osztályok, például a "container" és a "row", lehetővé teszik a tartalom elrendezését különböző kijelzőméretekre.

- Komponensek: Bootstrap számos előre elkészített komponenst kínál, mint például gombok, űrlapok, navigációs menük és modálok. Ezeket könnyen használhatjuk az alkalmazásunkban, és testreszabhatjuk őket az igényeink szerint.

- JavaScript komponensek: Bootstrap tartalmaz olyan JavaScript alapú komponenseket is, mint például üzenetablakok és húzható-csempék. Ezekkel az interakciókkal gazdagíthatjuk az alkalmazásunkat.

- Testreszabhatóság: Bár Bootstrap előre elkészített stílusokat kínál, könnyen testre szabhatjuk azokat a saját design elképzeléseink szerint. Ezt saját CSS stílusok hozzáadásával vagy az alap stílusok felülírásával tehetjük meg.
## Biztonság

A játék jelenleg nem tartalmaz bejelentkezési opciót, ezért nem tárolunk személyes adatokat a felhasználótól. A megadható játékosnév adat nem esik GRDP köteles tárolásmód alá. A játék nem tárol böngésző adatokat sem.

Cookie-k kezelése: A játék nem tárol Cookie-kat. A böngésző ettől függetlenül gyűjthet adatot a klienstől, viszont ezért nem a játék fejlesztői a felelősök.

## Tesztelés

A tesztekről részletes leírást kell készíteni a teszt jegyzőkönyv minta kitöltésével. A tesztelési folyamatokat legalább 3 böngészőn el kell végezni és dokumentálni! A jegyzőkönyv minta eléréshez kattints [IDE](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/tesztjegyzokonyv_minta.md) vagy a GitHub repo-ban **ProjectStructure/tesztjegyzokonyv_minta.md** elérési útvonalon találod a dokumentumot.

 Dokumentum megnyitához fejlesztői környezetet ajánlunk, mivel a dokumentum Markdown (.md) kiterjesztésű file. A dokumentum minőségének megőrzése érdekében a kitöltés után előnézetben meg kell vizsgálni a dokumentumot, hogy a kitöltött mezők **olvashatóak és egyértelműek.** 
 
 A projektért felelős személy(ek) minden jogot fenttartanak a tesztesetek visszautasítására és az adott tesztet elvégző tesztelő személy felszólítására annak megismétlésére.

Az alkalmazást alaposan teszteljük, beleértve a következő típusú teszteket:

1. **Funkcionális tesztek**: Ellenőrizzük, hogy az egyes funkciók a terveknek megfelelően működnek-e.

2. **Teljesítménytesztek**: Mérjük az alkalmazás teljesítményét, különös tekintettel az adatbázis műveletekre.


3. **Felhasználói interfész tesztek**: Ellenőrizzük a felhasználói felület megjelenítését és működését különböző böngészőkben és eszközökön.

A tesztelési folyamatokat legalább 3 böngészőn el kell végezni. Elhanyagolhatatlan a más keresőmotorral rendelkező böngészők tesztelése is a production kód kiadása előtt! A jegyzőkönyvnek tartalmaznia kell, hogy az adott teszteset melyik böngészőben és azon belül is melyik alkalmazás verzióval történt. [(Böngésző verzió ellenőrzése)](https://letmegooglethat.com/?q=Google+chrome+check+browser+version) 

Kötelező böngészők tesztelés folyamán: 
- Google Chrome
- Microsoft Edge
- Mozzilla Firefox

## Dokumentáció

Készítünk egy részletes dokumentációt, amely tartalmazza az alkalmazás telepítésének és használatának lépéseit, valamint a forráskód dokumentációját, beleértve a funkciók leírását és a kódban alkalmazott tervezési döntéseket.

## Fejlesztői Környezet és Kódkezelés
A fejlesztői környezetként a Visual Studio-t használjuk, amely egy erőteljes fejlesztői eszköz a .NET alkalmazásokhoz. A kódkezelés során a fejlesztők a GitHubot használják, hogy nyomon kövessék és kezeljék a változásokat a forráskódban. Ez lehetővé teszi a fejlesztők közötti együttmunkában és a verziókövetésben.

### Fizikai környezet
 #### Felhasználói környezet:
 Az alkalmazás Web-re lett fejlesztve, eléréséhez frissített böngészőt (Stabil verzió) kell használni. 
 #### Fejlesztői környezet:
 - Visual Studio
 - Visual Studio Code
 #### Ábrák
 - Lucidcharts 
 - Paint
 - Adobe Illustrator
 #### Kommunikáció
 - Discord
 - Messenger
 - Trello
 - In-Person meeting
 #### Verziókezelés
 - GitHub
 #### Egyéb használt szoftverek
 - Microsoft Word
 - Gmail
 
#### Használt packagek
 - Newtonsoft.Json 13.0.3
 - Mysql Connector 2.2.7
 - Xampp 8.2.4
 
## Böngészők és Platformok Támogatása
Az alkalmazás fejlesztése során a Google Chrome böngészőt használunk mint a fő fejlesztői platform. Azonban fontos, hogy az alkalmazás több böngészőben is megfelelően működjön, például Firefox, Safari és Edge. Az alkalmazás reszponzív dizájnt használ, így különböző eszközökön, például asztali számítógépeken, laptopokon, tableteken és mobiltelefonokon is jól működjön.

## Mobilalkalmazás Támogatás
Az alkalmazásnak lehetőséget kell biztosítania a mobilalkalmazásokhoz történő konverzióhoz, hogy a felhasználók különböző platformokon is élvezhessék a játékot. A mobilalkalmazásoknak is támogatniuk kell az előzően említett funkciókat és elvárásokat.

## Deployment
Az alkalmazás telepítésére és üzemeltetésére fontos figyelmet fordítani. Az alkalmazást szerveren (LOCALHOST) kell hostolni, és gondoskodni kell a szükséges infrastruktúra és környezet beállításáról. A telepítés során az adatbázis konfigurációját is be kell állítani, és gondoskodni kell a biztonsági intézkedésekről, például tűzfalakról és hozzáférési jogosultságokról.

## Verziókezelés
A fejlesztés során kulcsfontosságú a verziókezelés, amely lehetővé teszi a kód változásainak nyomon követését és visszavonását, ha szükséges. A GitHub használata segít a csapatmunkában és a verziókövetésben.

## Összegzés
Az elkészített követelményspecifikáció és architektúra tervek alapján az alkalmazás teljesíti a felhasználók szórakoztatását és kihívását szolgáló célját, miközben biztosítja a biztonságot és a rugalmasságot a felhasználói élmény növelése érdekében. Az alkalmazás fejlesztése, tesztelése és dokumentálása a minőségi működés és a felhasználói elégedettség elérésének kulcsfontosságú elemei.
