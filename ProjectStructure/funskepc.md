# Zoknipárosító Webalkalmazás Funkcionális Specifikáció

## Bevezetés

A zoknipárosító webalkalmazás egy olyan játékot kínál a felhasználóknak, ahol különböző zoknikat kell párosítaniuk az azonos mintájú vagy színű zoknik alapján. A játék három nehézségi fokozattal (könnyű, közepes, nehéz) rendelkezik, tartalmaz egy leaderboardot a játékosok pontszámainak megjelenítéséhez, és egy visszaszámlálót a játék időtartamának korlátozásához.

## Játék Funkcionális Leírása

### Bejelentkezés és Regisztráció

- A felhasználóknak lehetőséget kell kapniuk a nevük elmentéséhez és a játékadatok névhez való rendeléséhez.
- A felhasználó adatait nem tároljuk. Esetleges adattárolást a böngésző végezhet!

### Felhasználói interfész
- Az alkalmazásnak modern és felhasználóbarát grafikus felhasználói interfésszel kell rendelkeznie, amely egyszerűen kezelhető és vonzó.
- A játékterületen jól láthatóan és egyértelműen jelenjenek meg a zoknik.

   ![](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/ProjectStructure/img/Untitled.png)


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

### Többnyelvűség
Az alkalmazásnak támogatnia kell többnyelvűséget, hogy a felhasználók különböző nyelveken használhassák. Az alapértelmezett nyelv mellett a felhasználóknak választhatóan lehetőségük kell kapniuk a nyelv megváltoztatására, ami a felhasználói élmény sokszínűsítését szolgálja

### Mobilalkalmazás Támogatás
Az alkalmazásnak lehetőséget kell biztosítania a mobilalkalmazásokhoz történő konverzióhoz, hogy a felhasználók különböző platformokon is élvezhessék a játékot. A mobilalkalmazásoknak is támogatniuk kell az előzően említett funkciókat és elvárásokat.

### Felhasználói Visszajelzések
Az alkalmazásnak lehetőséget kell biztosítania a felhasználóknak, hogy visszajelzéseket küldjenek a fejlesztőknek. Ez segíthet az alkalmazás továbbfejlesztésében és hibajavításában.

[SECURITY DETAILS](https://github.com/albertbokor-unideb/zokniparosito-jatek/blob/main/SECURITY.md)

## Általános elvárások
- Könnyen üzemeltethető
- Gyerekek és fiatalkorúak számára könnyen kezelhető és átlátható weboldal
- Intuitív menürendszer
- Többnyelvűség
- Reszponzív dizájn

## Dokumentáció

20. Készítünk egy részletes dokumentációt, amely tartalmazza az alkalmazás használatának lépéseit, valamint a forráskód dokumentációját.
21. A dokumentációnak meg kell egyeznie a lehetséges frissítésekkel.
