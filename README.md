# UserManagementApp
Login nézet felhasználó bejelentkezéséhez.
Lista nézet keresés, XML export 
Szerkesztő nézet.

Struktúra
3 nézet
UserRepository S hozzá kapcsolódó interface
 IRepository T genetikus
 ILogin bejelentkezés feltételek ellenőrzése
 IXML XML be export
User
  IEdit - másolat, valodacio, mentés
  ICSV - betöltés, módosítás rögzítése
