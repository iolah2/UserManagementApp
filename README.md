# UserManagementApp
Login nézet felhasználó bejelentkezéséhez.
Lista nézet keresés, XML export. 
Szerkesztő nézet.

Struktúra
UserRepository a hozzá kapcsolódó interface-ekkel
 IRepository T genetikus
 ILogin bejelentkezés feltételek ellenőrzése
 IXML XML be export
User
  IEdit - másolat, validáció, mentés
  ICSV - betöltés, módosítás rögzítés
