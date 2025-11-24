# 📜 ACTIVITAT: CODEQUEST - JOC DE ROL PER CONSOLA
## 🎯 Descripció General

Has de crear un joc de rol RPG per consola en C# anomenat CodeQuest, on el jugador controla un mag que pot entrenar, pujar de nivell, aconseguir recursos, comprar objectes i desxifrar pergamins antics.
El joc ha de tenir un menú principal amb 7 opcions funcionals més l'opció de sortir.

## 📋 Requisits Funcionals
### Menú Principal

S'ha de mostrar repetidament fins que l'usuari triï sortir (opció 0). El menú inclou:

===== MAIN MENU - CODEQUEST =====
===== Welcome, [NOM] the [TÍTOL] with level [NIVELL] =====
Train your wizard - Entrenar el mag
Increase LVL - Combatre i pujar de nivell
Loot the mine - Minar per aconseguir bits (moneda del joc)
Show inventory - Mostrar inventari
Buy items - Comprar objectes
Show attacks by LVL - Veure atacs disponibles segons el nivell
Decode ancient Scroll - Desxifrar pergamins màgics
Exit game - Sortir

## 🔧 Funcionalitats per Chapter

### Chapter 1: Train your wizard

Sol·licita el nom del mag i el capitalitza correctament (primera lletra majúscula, resta minúscules)
- Simula 5 dies d'entrenament
- Cada dia genera aleatòriament:
    - Hores d'entrenament (entre 1 i 24)
    - Punts de poder guanyats (entre 1 i 10)
- En finalitzar, assigna un títol/rang segons el poder total acumulat:

| Punts de Poder | Títol | Missatge |
|----------------|-------|----------|
|< 20 | Raoden el Elantrí | Repeteixes a 2a convocatòria. |
| 20-29 | Zyn el Buguejat | Encara confons la vareta amb una cullera. |
| 30-34 | Arka Nullpointer | Ets un Invocador de Brises Màgiques. |
| 35-39 | Elarion de les Brases | Uau! Pots invocar dracs sense cremar el laboratori! |
| ≥ 40 | ITB-Wizard el Gris | Has assolit el rang de Mestre dels Arcans! |

### Chapter 2: Increase LVL

- Apareix un monstre aleatori amb els seus punts de vida (HP)
- El jugador tira un dau (aleatori entre 1 i 6).
- Cada tirada resta HP al monstre i mostra un ASCII art del dau
- Quan el monstre arriba a 0 HP, el jugador puja un nivell (màxim nivell 5)

| Monstre | HP |
|---------|----|
| Wandering Skeleton 💀 | 3 |
| Forest Goblin 👹 | 5 |
| Green Slime 🟢 | 10 |
| Ember Wolf 🐺 | 11 |
| Giant Spider 🕷️ | 18 |
| Iron Golem 🤖 | 15 |
| Lost Necromancer 🧝‍♂️ | 20 |
| Ancient Dragon 🐉 | 50 |

S'ha d'utilitzar art ASCII per deibuixar els daus:
```
   ________
  /       /|   
 /_______/ |
 |       | |
 |   o   | /
 |       |/ 
 '-------'
```

### Chapter 3: Loot the mine

- Mostra una matriu 5x5 buida al principi
- El jugador té 5 intents per minar
- Ha d'introduir coordenades X i Y
- La matriu té posicions amb monedes (generades aleatòriament a l'inici)
- Si encerta, guanya entre 5 i 50 bits
- Mostra la matriu actualitzada després de cada intent amb símbols:
    - ➖ = No excavat
    - 🪙 = Moneda trobada
    - ❌ = Excavat sense èxit

### Chapter 4: Show inventory

- Mostra tots els objectes comprats
- Si està buit, indica que no hi ha objectes

### Chapter 5: Buy items

- Mostra els objectes disponibles amb els seus preus
- El jugador selecciona un número
- Si té prou bits, compra l'objecte i s'afegeix a l'inventari
- Els bits es descompten

| Objecte | Preu (bits) |
|---------|-------------|
| Iron Dagger 🗡️ | 30 |
| Healing Potion ⚗️ | 10 |
| Ancient Key 🗝️ | 50 |
| Crossbow 🏹 | 40 |
| Metal Shield 🛡️ | 20 |

### Chapter 6: Show attacks by LVL

- Mostra els atacs disponibles segons el nivell actual del mag
- Cada nivell té diferents atacs

### Chapter 7: Decode ancient Scroll

Presenta 3 sub-opcions per treballar amb el desxifratge del pergamí:

- Eliminar espais del primer pergamí
- Comptar vocals (incloses accentuades) del segon pergamí
- Extreure números del tercer pergamí

Quan es completen les 3 tasques, mostra un missatge d'èxit.
