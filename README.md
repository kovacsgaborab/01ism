# Játékprogram - (Kő, Papír, Olló)

## Játékmenet 1.0
- [x] A számítógép választ egy lehetőséget
- [x] A felhasználó megad egy lehetőséget
- Nyerés:
	- Kő legyőzi az Ollót
	- Papír legyőzi a Követ
	- Ollólegyőzi a Papírt
- [x] A nyerés megállapítását kiszervezzük metódusba
    - embernyer()
    - visszaadott érték -> 0, 1, 2
      - 0: döntetlen
      - 1: gép nyer
      - 2: ember nyer
- [x] Kiírjuk az eredményt
    - kiírás külön metódusban

## Játékmenet 2.0
- [x] Addig játszunk, amíg ki nem lépünk a játékból
- [x] Statisztika megvalósítás
    - gép, játékos, mennyi menet
- [x] Eredmények fileba írása és megjelenítése
    - 1. érték -> menet
    - 2. érték -> játékos
    - 3. érték -> gép
    - értékek ';'-vel elválasztva