# Zoknipárosító Játék Követelményspecifikáció

## Bevezetés
A zoknipárosító játék egy szórakoztató és kihívást jelentő alkalmazás, amely lehetővé teszi a felhasználók számára, hogy párosítsák össze a különböző színű és mintázatú zoknikat. Az alkalmazásnak három nehézségi fokozattal kell rendelkeznie (könnyű, közepes, nehéz), egy leaderboarddal, ahol a játékosok versenghetnek, és egy visszaszámlálóval, ami korlátozza a játék időtartamát.

## Követelmények

### Felhasználói interfész
1. Az alkalmazásnak modern és felhasználóbarát grafikus felhasználói interfésszel kell rendelkeznie, amely egyszerűen kezelhető és vonzó.
2. A játékterületen jól láthatóan és egyértelműen jelenjenek meg a zoknik.

### Nehézségi fokozatok
3. A játék három nehézségi fokozattal rendelkezik: könnyű, közepes és nehéz.
4. Könnyű fokozatban kevesebb zoknit jelenítsen meg, és hosszabb idő álljon rendelkezésre a játékhoz.
5. Közepes fokozatban közepes mennyiségű zoknit jelenítsen meg, és közepes időlimit legyen.
6. Nehéz fokozatban több zoknit jelenítsen meg, és legyen kevesebb időlimit.

### Játékmenet
7. A játék indulásakor véletlenszerűen jelenjenek meg a zoknik a játékterületen, úgy, hogy a párosításokat ne lehessen előre kiszámolni.
8. A felhasználónak két zoknit kell párosítania az azonos szín vagy mintázat alapján. Amennyiben egy párosítás sikeres, a zoknik eltűnnek a játékterületről.
9. A játékosok pontokat kapnak minden sikeres párosításért. A pontszámot az eltelt idő is befolyásolja.
10. Az időtartamot visszaszámláló mutatja, és amikor lejár, a játék véget ér.
11. Amennyiben a játékosnak sikerül az összes zoknit párosítania az idő lejárta előtt, a játék véget ér, és a játékos nyer.
12. Ha az idő lejár, és még nem párosította össze az összes zoknit, a játék véget ér, és a játékos veszít.

### SQL Adatbázis
13. Az alkalmazásnak egy SQL adatbázissal kell rendelkeznie a játékosok adatainak tárolására, beleértve a nevüket, pontszámukat és nehézségi fokozatukat.
14. Az adatbázisnak biztonságosnak kell lennie, és jelszavak titkosítva tárolódjanak.
15. Az adatbázisnak lehetőséget kell biztosítani a játékosok eredményeinek frissítésére és lekérdezésére.

### Leaderboard
16. Az alkalmazásnak egy leaderboard funkcióval kell rendelkeznie, ahol a játékosok eredményei megjelennek.
17. A leaderboardon a legjobb pontszámoknak és játékosoknak előnyt kell élvezniük.
18. A leaderboardon megjelenő adatok között kell szerepelni a játékosok nevét, pontszámát és nehézségi fokozatát.
19. A játékosok rangsorolása a pontszámok alapján történik, és a leaderboard folyamatosan frissüljön.

## Technikai Követelmények

### Platform
20. Az alkalmazás .NET keretrendszeren kell futnia, és C# programozási nyelvet kell használnia.

### Adatbázis
21. Az SQL adatbázisnak kompatibilisnek kell lennie a .NET keretrendszerrel, és adatainak hatékonyan kell tárolódnia és lekérdezhetőnek kell lennie.

### Felhasználói interfész
22. A felhasználói interfésznek reszponzív dizájnnal kell rendelkeznie, hogy különböző képernyőméretekhez alkalmazkodjon.

## Tesztelés
23. Az alkalmazást alaposan kell tesztelni, beleértve a funkcionalitást, a teljesítményt és a biztonságot is, hogy biztosítsuk a hibamentes működést és a felhasználói élményt.

## Dokumentáció
24. A fejlesztőknek részletes dokumentációt kell készíteniük, amely tartalmazza az alkalmazás telepítési és használati útmutatóját, valamint a forráskód dokumentációját.

Ez a részletes követelményspecifikáció definiálja az alkalmazás alapvető követelményeit a tervezés és fejlesztés során. Az alkalmazásnak meg kell felelnie ezeknek a követelmény

eknek, hogy sikeresen és kielégítően működjön a felhasználók számára. A további fejlesztés során fontos, hogy a részleteket kidolgozzák és a tesztelés során ellenőrizzék a megfelelőséget.

# -------------------------------------------------------

# Zoknipárosító Webalkalmazás Funkcionális Specifikáció

## Bevezetés

A zoknipárosító webalkalmazás egy olyan játékot kínál a felhasználóknak, ahol különböző zoknikat kell párosítaniuk az azonos mintájú vagy színű zoknik alapján. A játék három nehézségi fokozattal (könnyű, közepes, nehéz) rendelkezik, tartalmaz egy leaderboardot a játékosok pontszámainak megjelenítéséhez, és egy visszaszámlálót a játék időtartamának korlátozásához.

## Játék Funkcionális Leírása

### Bejelentkezés és Regisztráció

1. A felhasználóknak lehetőséget kell kapniuk a nevük elmentéséhez és a játékadatok névhez való rendeléséhez.

### Főoldal

2. A főoldalon jelenjen meg a START/KEZDÉS gomb.
3. A főoldalon jelenjen meg a nehézséget kiválasztó gomb: NEHÉZSÉG/DIFFICULTY 
4. A felhasználóknak lehetőségük van új játék indítására, nehézségi fokozat választására és a leaderboard megtekintésére.
5. A felhasználóknak lehetőségük van nyelvek között váltani: NYELV/LANGUAGE. Elérhető nyelvek: Angol, Magyar

### Játékmenet

6. A játékterületen jelenjenek meg a zoknik véletlenszerűen, úgy, hogy a párosításokat ne lehessen előre kiszámolni.
7. A felhasználók kattintással választhatják ki a zoknikat, amiket párosítani szeretnének.
8. Amikor a felhasználó két azonos zoknit párosít, azok eltűnnek a játékterületről.
9. A játék visszaszámlálóval rendelkezik, amely mutatja az eltelt időt.
10. Az idő lejárta előtt a felhasználónak meg kell találnia az összes párosítást a győzelemhez.
11. Ha az idő lejár, a játék véget ér, és a felhasználó veszít.

### Leaderboard

12. A leaderboardon megjelennek a játékosok, rendezve a pontszámok alapján, a legmagasabb pontszámoktól a legalacsonyabbig.
13. A leaderboard tartalmazza a játékosok nevét és pontszámát.
14. A játékosoknak lehetőségük van megtekinteni a leaderboard teljes listáját.

## Adatbázis Funkcionális Leírása

### Felhasználók

15. Az adatbázisban tároljuk a felhasználók adatait, beleértve a felhasználónevet, azonosítót.

### Játék Eredmények

16. Az adatbázisban tároljuk a játékosok játék eredményeit, beleértve a nevet, a pontszámot, a nehézségi fokozatot és a játék dátumát.

## Technikai Követelmények

17. Az alkalmazás egy ASP.NET webalkalmazásként valósul meg C# nyelven, használva a .NET keretrendszert.

## Tesztelés

18. Az alkalmazást alaposan teszteljük, beleértve az egyes funkciók, a teljesítmény és nyelvi beállítások helyességét.
19. A tesztelés folyamata alatt tesztelési jegyzőkönyvet kell kitöltenie a tesztelőnek minden tesztesetről.



## Dokumentáció

20. Készítünk egy részletes dokumentációt, amely tartalmazza az alkalmazás használatának lépéseit, valamint a forráskód dokumentációját.
21. A dokumentációnak meg kell egyeznie a lehetséges frissítésekkel.

