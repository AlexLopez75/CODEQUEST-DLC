# Chapter 5: Buy items

Normal:
- Initial totalBits: 150
- Player buys: Iron Dagger (30 bits), Healing Potion (10 bits), Metal Shield (20 bits)
- Final totalBits: 90

| Instruction | Iteration | shopSelect | totalBits | arrayPrice[shopSelect-1] | inventorySlots.Length | validInput | Output |
|------------|----------|------------|-----------|-------------------------|----------------------|------------|--------|
| 1 | - | 1 | 150 | - | 1 | false | Initialize shop |
| 2 | - | 1 | 150 | - | 1 | false | WRITE = "Welcome to the shop, kid. What will you buy?" |
| 3 | 1 | 1 | 150 | - | 1 | false | WRITE = "Item\t\t\tPrice" |
| 3 | 2 | 1 | 150 | - | 1 | false | Display all items and prices |
| 3 | 3 | 1 | 150 | - | 1 | false | WRITE = "Input (1-5) to select an item to purchase or 0 to exit the shop." |
| 3 | 4 | 1 | 150 | - | 1 | false | WRITE = "You have 150 bits in your possesion." |
| 3 | 5 | 1 | 150 | - | 1 | true | READ input = "1" |
| 3 | 6 | 1 | 150 | - | 1 | true | TryParse succeeds, shopSelect = 1 |
| 3 | 7 | 1 | 150 | - | 1 | true | Check: shopSelect >= 1 && shopSelect < 6 = true |
| 3 | 8 | 1 | 150 | 30 | 1 | true | arrayPrice[0] = 30 |
| 3 | 9 | 1 | 150 | 30 | 1 | true | Check: totalBits < 30 = false |
| 3 | 10 | 1 | 150 | 30 | 1 | true | inventorySlots[0] = "Iron Dagger 🗡️" |
| 3 | 11 | 1 | 120 | 30 | 1 | true | totalBits = 150 - 30 = 120 |
| 3 | 12 | 1 | 120 | 30 | 1 | true | WRITE = "Thank you for your purchase, kid." |
| 3 | 13 | 1 | 120 | 30 | 1 | true | WRITE = "You have bought a Iron Dagger 🗡️." |
| 3 | 14 | 1 | 120 | 30 | 2 | true | Create auxArray, copy items, resize inventorySlots to length 2 |
| 4 | 1 | 1 | 120 | 30 | 2 | false | Loop back, display shop menu |
| 4 | 2 | 1 | 120 | - | 2 | false | WRITE = "You have 120 bits in your possesion." |
| 4 | 3 | 2 | 120 | - | 2 | true | READ input = "2", shopSelect = 2 |
| 4 | 4 | 2 | 120 | 10 | 2 | true | arrayPrice[1] = 10 |
| 4 | 5 | 2 | 120 | 10 | 2 | true | Check: totalBits < 10 = false |
| 4 | 6 | 2 | 120 | 10 | 2 | true | inventorySlots[1] = "Healing Potion ⚗️" |
| 4 | 7 | 2 | 110 | 10 | 2 | true | totalBits = 120 - 10 = 110 |
| 4 | 8 | 2 | 110 | 10 | 2 | true | WRITE = "Thank you for your purchase, kid." |
| 4 | 9 | 2 | 110 | 10 | 2 | true | WRITE = "You have bought a Healing Potion ⚗️." |
| 4 | 10 | 2 | 110 | 10 | 3 | true | Resize inventorySlots to length 3 |
| 5 | 1 | 2 | 110 | 10 | 3 | false | Loop back, display shop menu |
| 5 | 2 | 2 | 110 | - | 3 | false | WRITE = "You have 110 bits in your possesion." |
| 5 | 3 | 5 | 110 | - | 3 | true | READ input = "5", shopSelect = 5 |
| 5 | 4 | 5 | 110 | 20 | 3 | true | arrayPrice[4] = 20 |
| 5 | 5 | 5 | 110 | 20 | 3 | true | Check: totalBits < 20 = false |
| 5 | 6 | 5 | 110 | 20 | 3 | true | inventorySlots[2] = "Metal Shield 🛡️" |
| 5 | 7 | 5 | 90 | 20 | 3 | true | totalBits = 110 - 20 = 90 |
| 5 | 8 | 5 | 90 | 20 | 3 | true | WRITE = "Thank you for your purchase, kid." |
| 5 | 9 | 5 | 90 | 20 | 3 | true | WRITE = "You have bought a Metal Shield 🛡️." |
| 5 | 10 | 5 | 90 | 20 | 4 | true | Resize inventorySlots to length 4 |
| 6 | 1 | 5 | 90 | 20 | 4 | false | Loop back, display shop menu |
| 6 | 2 | 5 | 90 | - | 4 | false | WRITE = "You have 90 bits in your possesion." |
| 6 | 3 | 0 | 90 | - | 4 | true | READ input = "0", shopSelect = 0 |
| 7 | - | 0 | 90 | - | 4 | true | Exit loop (shopSelect == 0) |
| 8 | - | 0 | 90 | - | 4 | true | WRITE = "Come again, kid." |

Limit:
- Initial totalBits: 25
- Player tries to buy: Ancient Key (50 bits - fails), Crossbow (40 bits - fails), Healing Potion (10 bits - succeeds)
- Final totalBits: 15

| Instruction | Iteration | shopSelect | totalBits | arrayPrice[shopSelect-1] | inventorySlots.Length | validInput | Output |
|------------|----------|------------|-----------|-------------------------|----------------------|------------|--------|
| 1 | - | 1 | 25 | - | 1 | false | Initialize shop |
| 2 | - | 1 | 25 | - | 1 | false | WRITE = "Welcome to the shop, kid. What will you buy?" |
| 3 | 1 | 1 | 25 | - | 1 | false | Display shop menu |
| 3 | 2 | 1 | 25 | - | 1 | false | WRITE = "You have 25 bits in your possesion." |
| 3 | 3 | 3 | 25 | - | 1 | true | READ input = "3", shopSelect = 3 |
| 3 | 4 | 3 | 25 | - | 1 | true | Check: shopSelect >= 1 && shopSelect < 6 = true |
| 3 | 5 | 3 | 25 | 50 | 1 | true | arrayPrice[2] = 50 |
| 3 | 6 | 3 | 25 | 50 | 1 | true | Check: totalBits < 50 = true |
| 3 | 7 | 3 | 25 | 50 | 1 | true | WRITE = "It seems you dont have enough bits. Come when you have more, kid." |
| 4 | 1 | 3 | 25 | 50 | 1 | false | Loop back, display shop menu |
| 4 | 2 | 3 | 25 | - | 1 | false | WRITE = "You have 25 bits in your possesion." |
| 4 | 3 | 4 | 25 | - | 1 | true | READ input = "4", shopSelect = 4 |
| 4 | 4 | 4 | 25 | 40 | 1 | true | arrayPrice[3] = 40 |
| 4 | 5 | 4 | 25 | 40 | 1 | true | Check: totalBits < 40 = true |
| 4 | 6 | 4 | 25 | 40 | 1 | true | WRITE = "It seems you dont have enough bits. Come when you have more, kid." |
| 5 | 1 | 4 | 25 | 40 | 1 | false | Loop back, display shop menu |
| 5 | 2 | 4 | 25 | - | 1 | false | WRITE = "You have 25 bits in your possesion." |
| 5 | 3 | 2 | 25 | - | 1 | true | READ input = "2", shopSelect = 2 |
| 5 | 4 | 2 | 25 | 10 | 1 | true | arrayPrice[1] = 10 |
| 5 | 5 | 2 | 25 | 10 | 1 | true | Check: totalBits < 10 = false |
| 5 | 6 | 2 | 25 | 10 | 1 | true | inventorySlots[0] = "Healing Potion ⚗️" |
| 5 | 7 | 2 | 15 | 10 | 1 | true | totalBits = 25 - 10 = 15 |
| 5 | 8 | 2 | 15 | 10 | 1 | true | WRITE = "Thank you for your purchase, kid." |
| 5 | 9 | 2 | 15 | 10 | 1 | true | WRITE = "You have bought a Healing Potion ⚗️." |
| 5 | 10 | 2 | 15 | 10 | 2 | true | Resize inventorySlots to length 2 |
| 6 | 1 | 2 | 15 | 10 | 2 | false | Loop back, display shop menu |
| 6 | 2 | 2 | 15 | - | 2 | false | WRITE = "You have 15 bits in your possesion." |
| 6 | 3 | 0 | 15 | - | 2 | true | READ input = "0", shopSelect = 0 |
| 7 | - | 0 | 15 | - | 2 | true | Exit loop |
| 8 | - | 0 | 15 | - | 2 | true | WRITE = "Come again, kid." |

Error:
- Initial totalBits: 50
- Invalid inputs: "abc", "10", "-1"
- Valid purchase: Iron Dagger (30 bits)
- Final totalBits: 20

| Instruction | Iteration | shopSelect | totalBits | validInput | Output |
|------------|----------|------------|-----------|------------|--------|
| 1 | - | 1 | 50 | false | Initialize shop |
| 2 | - | 1 | 50 | false | WRITE = "Welcome to the shop, kid. What will you buy?" |
| 3 | 1 | 1 | 50 | false | Display shop menu |
| 3 | 2 | 1 | 50 | false | WRITE = "You have 50 bits in your possesion." |
| 3 | 3 | 1 | 50 | false | READ input = "abc" |
| 3 | 4 | 1 | 50 | false | TryParse fails, validInput = false |
| 3 | 5 | 1 | 50 | false | Catch FormatException |
| 3 | 6 | 1 | 50 | false | WRITE = "Input a number from 1 and 7." |
| 4 | 1 | 1 | 50 | false | Loop back, display shop menu |
| 4 | 2 | 1 | 50 | false | WRITE = "You have 50 bits in your possesion." |
| 4 | 3 | 10 | 50 | true | READ input = "10" |
| 4 | 4 | 10 | 50 | true | TryParse succeeds, shopSelect = 10 |
| 4 | 5 | 10 | 50 | true | Check: shopSelect >= 1 && shopSelect < 6 = false |
| 4 | 6 | 10 | 50 | true | Condition not met, no action taken |
| 5 | 1 | 10 | 50 | false | Loop back, display shop menu |
| 5 | 2 | 10 | 50 | false | WRITE = "You have 50 bits in your possesion." |
| 5 | 3 | -1 | 50 | true | READ input = "-1" |
| 5 | 4 | -1 | 50 | true | TryParse succeeds, shopSelect = -1 |
| 5 | 5 | -1 | 50 | true | Check: shopSelect >= 1 && shopSelect < 6 = false |
| 5 | 6 | -1 | 50 | true | Condition not met, no action taken |
| 6 | 1 | -1 | 50 | false | Loop back, display shop menu |
| 6 | 2 | -1 | 50 | false | WRITE = "You have 50 bits in your possesion." |
| 6 | 3 | 1 | 50 | true | READ input = "1", shopSelect = 1 |
| 6 | 4 | 1 | 50 | true | Check: shopSelect >= 1 && shopSelect < 6 = true |
| 6 | 5 | 1 | 50 | true | arrayPrice[0] = 30 |
| 6 | 6 | 1 | 50 | true | Check: totalBits < 30 = false |
| 6 | 7 | 1 | 50 | true | inventorySlots[0] = "Iron Dagger 🗡️" |
| 6 | 8 | 1 | 20 | true | totalBits = 50 - 30 = 20 |
| 6 | 9 | 1 | 20 | true | WRITE = "Thank you for your purchase, kid." |
| 6 | 10 | 1 | 20 | true | WRITE = "You have bought a Iron Dagger 🗡️." |
| 6 | 11 | 1 | 20 | true | Resize inventorySlots to length 2 |
| 7 | 1 | 1 | 20 | false | Loop back, display shop menu |
| 7 | 2 | 1 | 20 | false | WRITE = "You have 20 bits in your possesion." |
| 7 | 3 | 0 | 20 | true | READ input = "0", shopSelect = 0 |
| 8 | - | 0 | 20 | true | Exit loop |
| 9 | - | 0 | 20 | true | WRITE = "Come again, kid." |