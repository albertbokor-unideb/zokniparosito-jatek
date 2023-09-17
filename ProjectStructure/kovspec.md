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