
# Zoknipárosító Webalkalmazás Rendszerterve

## Architektúra

Az alkalmazás egy háromrétegű architektúrával fog működni:

1. **Felhasználói réteg (Presentation Layer)**: Ez a réteg felelős a felhasználói interfész megjelenítéséért és a felhasználói interakciók kezeléséért. Az ASP.NET webalkalmazás lesz felelős a felhasználói felület megjelenítéséért és a kliensoldali logika végrehajtásáért.

2. **Üzleti réteg (Business Layer)**: Ez a réteg tartalmazza az alkalmazás üzleti logikáját és az adatfeldolgozást. Ide tartoznak a játékmenet vezérlése, a leaderboard kezelése és a felhasználók játékadatainak logikája.

3. **Adatbázis réteg (Data Layer)**: Az adatbázis rétegben található az SQL adatbázis, amely tárolja a felhasználók játékadatait és a játék eredményeit.

## Adatbázis

Az alkalmazás egy SQL adatbázist használ a felhasználói adatok és a játék eredményeinek tárolására. Az adatbázis tartalmazza a következő táblákat:

1. **leaderboard**: Ebben a táblában rögzítjük a játékosok játék eredményeit, beleértve a játékos nevét, a pontszámát, a nehézségi fokozatot és a játék dátumát.
2. **zokni**: Ebben a táblában rögzítjük a különböző zokinik modelljét, amelyeket ellátunk egy id-val is és nehézségi szinttel is. A játék betöltésekor innen nyerjük ki véletlenszerűen a bizonyos nehézségi szinthez járó zoknik számát és nehézségi szintjét.
3. **palyak**: A Pályák nevű táblában tároljuk a pálya nevét, nehézségét és az időkorlátot amely alatt teljesíteni kell a megadott pályát.

## Felhasználói Interfész

Az alkalmazás webes felhasználói felületet használ, amely HTML, CSS és JavaScript segítségével van megvalósítva. A felhasználói interfész tartalmazza a következő oldalakat és elemeket:


1. **Főoldal**: A főoldalon jelenik meg a menü ahol a játékos kiválaszthatja a játék nyelvét (Magyar/Angol), a játék nehézségét (Könnyű, Közepes, Nehéz) és itt tekintheti meg a Leaderboardot is.

2. **Játékterület**: A játékterületen jelennek meg a zoknik, és itt zajlik a játék. A játéktér tetején jelenik meg a számláló.

3. **Leaderboard**: A leaderboard oldalon láthatók a legjobb pontszámok és a játékosok nevei.

## Biztonság

A játék jelenleg nem tartalmaz bejelentkezési opciót, ezért nem tárolunk személyes adatokat a felhasználótól. A megadható játékosnév adat nem esik GRDP köteles tárolásmód alá. A játék nem tárol böngésző adatokat sem.

Cookie-k kezelése: A játék nem tárol Cookie-kat. A böngésző ettől függetlenül gyűjthet adatot a klienstől, viszont ezért nem a játék fejlesztői a felelősök. 
## Tesztelés

Az alkalmazást alaposan teszteljük, beleértve a következő típusú teszteket:

1. **Funkcionális tesztek**: Ellenőrizzük, hogy az egyes funkciók a terveknek megfelelően működnek-e.

2. **Teljesítménytesztek**: Mérjük az alkalmazás teljesítményét, különös tekintettel az adatbázis műveletekre.


3. **Felhasználói interfész tesztek**: Ellenőrizzük a felhasználói felület megjelenítését és működését különböző böngészőkben és eszközökön.

## Dokumentáció

Készítünk egy részletes dokumentációt, amely tartalmazza az alkalmazás telepítésének és használatának lépéseit, valamint a forráskód dokumentációját, beleértve a funkciók leírását és a kódban alkalmazott tervezési döntéseket.
