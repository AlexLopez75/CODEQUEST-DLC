# Chapter 3: Loot the Mine

Normal:

| Instruction | Iteration | attempts | row | column | matrixTreasure[row,column] | matrixMap[row,column] | bits | totalBits | Output |
|-------------|-----------|----------|-----|--------|----------------------------|-----------------------|------|-----------|--------|
| 1 | - | 5 | - | - | - | - | 0 | 0 | Initialize matrices |
| 2 | - | 5 | - | - | - | - | 0 | 0 | WRITE = "Here's the map of the mine." |
| 3 | - | 5 | - | - | - | - | 0 | 0 | Display initial map with all ➖ |
| 4 | 1 | 5 | - | - | - | - | 0 | 0 | WRITE = "You have 5 attempts left." |
| 4 | 2 | 5 | - | - | - | - | 0 | 0 | WRITE = "Input a row (0-4):" |
| 4 | 3 | 5 | 0 | - | - | - | 0 | 0 | READ row = 0 |
| 4 | 4 | 5 | 0 | - | - | - | 0 | 0 | WRITE = "Input a column (0-4):" |
| 4 | 5 | 5 | 0 | 0 | - | - | 0 | 0 | READ column = 0 |
| 4 | 6 | 5 | 0 | 0 | - | - | 0 | 0 | WRITE = "Digging in coordinates (0,0)..." |
| 4 | 7 | 5 | 0 | 0 | 🪙 | ➖ | 0 | 0 | Check: matrixTreasure[0,0] == 🪙 |
| 4 | 8 | 5 | 0 | 0 | 🪙 | 🪙 | 25 | 0 | matrixMap[0,0] = 🪙, bits = 25 |
| 4 | 9 | 5 | 0 | 0 | 🪙 | 🪙 | 25 | 25 | totalBits = 25 |
| 4 | 10 | 5 | 0 | 0 | 🪙 | 🪙 | 25 | 25 | WRITE = "You struck a gold! Bits found: 25" |
| 4 | 11 | 5 | 0 | 0 | 🪙 | 🪙 | 25 | 25 | Display updated map |
| 5 | 1 | 4 | - | - | - | - | 25 | 25 | attempts--, WRITE = "You have 4 attempts left." |
| 5 | 2 | 4 | 1 | - | - | - | 25 | 25 | WRITE = "Input a row (0-4):", READ row = 1 |
| 5 | 2 | 4 | 1 | 1 | - | - | 25 | 25 | WRITE = "Input a column (0-4):", READ column = 1 |
| 5 | 3 | 4 | 1 | 1 | - | - | 25 | 25 | WRITE = "Digging in coordinates (1,1)..." |
| 5 | 4 | 4 | 1 | 1 | ❌ | ➖ | 25 | 25 | Check: matrixTreasure[1,1] == ❌ |
| 5 | 5 | 4 | 1 | 1 | ❌ | ❌ | 25 | 25 | matrixMap[1,1] = ❌ |
| 5 | 6 | 4 | 1 | 1 | ❌ | ❌ | 25 | 25 | WRITE = "There's nothing in here." |
| 5 | 7 | 4 | 1 | 1 | ❌ | ❌ | 25 | 25 | Display updated map |
| 6 | 1 | 3 | - | - | - | - | 25 | 25 | attempts--, WRITE = "You have 3 attempts left." |
| 6 | 2 | 3 | 2 | 2 | - | - | 25 | 25 | READ row = 2, column = 2 |
| 6 | 3 | 3 | 2 | 2 | - | - | 25 | 25 | WRITE = "Digging in coordinates (2,2)..." |
| 6 | 4 | 3 | 2 | 2 | 🪙 | 🪙 | 15 | 40 | matrixMap[2,2] = 🪙, bits = 15, totalBits = 40 |
| 6 | 5 | 3 | 2 | 2 | 🪙 | 🪙 | 15 | 40 | WRITE = "You struck a gold! Bits found: 15" |
| 6 | 6 | 3 | 2 | 2 | 🪙 | 🪙 | 15 | 40 | Display updated map |
| 7 | 1 | 2 | 3 | 3 | - | - | 15 | 40 | attempts--, READ row = 3, column = 3 |
| 7 | 2 | 2 | 3 | 3 | ❌ | ❌ | 15 | 40 | matrixMap[3,3] = ❌, WRITE = "There's nothing in here." |
| 7 | 3 | 2 | 3 | 3 | ❌ | ❌ | 15 | 40 | Display updated map |
| 8 | 1 | 1 | 4 | 4 | - | - | 15 | 40 | attempts--, READ row = 4, column = 4 |
| 8 | 2 | 1 | 4 | 4 | 🪙 | 🪙 | 30 | 70 | matrixMap[4,4] = 🪙, bits = 30, totalBits = 70 |
| 8 | 3 | 1 | 4 | 4 | 🪙 | 🪙 | 30 | 70 | WRITE = "You struck a gold! Bits found: 30" |
| 8 | 4 | 1 | 4 | 4 | 🪙 | 🪙 | 30 | 70 | Display updated map |
| 9 | - | 0 | - | - | - | - | 30 | 70 | attempts = 0, exit loop |
| 10 | - | 0 | - | - | - | - | 30 | 70 | WRITE = "You have found a total of 70 bits in this mine" |


Limit: Repeat the same coordinates(2,2)

| Instruction | Iteration | attempts | row | column | matrixTreasure[row,column] | matrixMap[row,column] | bits | totalBits | Output |
|------------|----------|----------|-----|--------|---------------------------|----------------------|------|-----------|--------|
| 1 | - | 5 | - | - | - | - | 0 | 0 | Initialize matrices |
| 2 | - | 5 | - | - | - | - | 0 | 0 | WRITE = "Here's the map of the mine." |
| 3 | - | 5 | - | - | - | - | 0 | 0 | Display initial map with all ➖ |
| 4 | 1 | 5 | - | - | - | - | 0 | 0 | WRITE = "You have 5 attempts left." |
| 4 | 2 | 5 | 2 | 2 | - | ➖ | 0 | 0 | READ row = 2, column = 2 |
| 4 | 3 | 5 | 2 | 2 | - | ➖ | 0 | 0 | WRITE = "Digging in coordinates (2,2)..." |
| 4 | 4 | 5 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | matrixMap[2,2] = 🪙, bits = 20, totalBits = 20 |
| 4 | 5 | 5 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | WRITE = "You struck a gold! Bits found: 20" |
| 4 | 6 | 5 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | Display updated map |
| 5 | 1 | 4 | - | - | - | - | 20 | 20 | attempts--, WRITE = "You have 4 attempts left." |
| 5 | 2 | 4 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | READ row = 2, column = 2 |
| 5 | 3 | 4 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | WRITE = "Digging in coordinates (2,2)..." |
| 5 | 4 | 5 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | attempts++ (restored) |
| 5 | 5 | 5 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | WRITE = "You have already digged this coordenate" |
| 5 | 6 | 5 | 2 | 2 | 🪙 | 🪙 | 20 | 20 | Display updated map |
| 5 | 7 | 4 | - | - | - | - | 20 | 20 | attempts--, WRITE = "You have 4 attempts left." |
| 5 | 8 | 4 | 0 | 0 | ❌ | ❌ | 20 | 20 | READ row = 0, column = 0, dig empty cell |
| 5 | 9 | 4 | 0 | 0 | ❌ | ❌ | 20 | 20 | WRITE = "There's nothing in here." |
| 6 | - | 3 | 1 | 1 | ❌ | ❌ | 20 | 20 | attempts--, dig another empty cell |
| 7 | - | 2 | 3 | 3 | ❌ | ❌ | 20 | 20 | attempts--, dig another empty cell |
| 8 | - | 1 | 4 | 4 | ❌ | ❌ | 20 | 20 | attempts--, dig final empty cell |
| 9 | - | 0 | - | - | - | - | 20 | 20 | attempts = 0, exit loop |
| 10 | - | 0 | - | - | - | - | 20 | 20 | WRITE = "You have found a total of 20 bits in this mine" |

Error:
- First attempt: Invalid row input "abc"
- Second attempt: Row = 7 (out of range)
- Third attempt: Column = -1 (out of range)
- Fourth attempt: Valid coordinate (1,1) with treasure, bits = 35

| Instruction | Iteration | attempts | row | column | validInput | matrixMap[row,column] | bits | totalBits | Output |
|------------|----------|----------|-----|--------|-----------|----------------------|------|-----------|--------|
| 1 | - | 5 | - | - | false | - | 0 | 0 | Initialize matrices |
| 2 | - | 5 | - | - | false | - | 0 | 0 | WRITE = "Here's the map of the mine." |
| 3 | - | 5 | - | - | false | - | 0 | 0 | Display initial map |
| 4 | 1 | 5 | - | - | false | - | 0 | 0 | WRITE = "You have 5 attempts left." |
| 4 | 2 | 5 | - | - | false | - | 0 | 0 | WRITE = "Input a row (0-4):" |
| 4 | 3 | 5 | - | - | false | - | 0 | 0 | READ input = "abc" |
| 4 | 4 | 5 | 0 | - | false | - | 0 | 0 | TryParse fails, validInput = false |
| 4 | 5 | 5 | 0 | - | false | - | 0 | 0 | WRITE = "Input a number between 0 and 4" |
| 4 | 6 | 5 | - | - | false | - | 0 | 0 | Loop back, WRITE = "Input a row (0-4):" |
| 4 | 7 | 5 | - | - | true | - | 0 | 0 | READ input = "7" |
| 4 | 8 | 5 | 7 | - | true | - | 0 | 0 | TryParse succeeds, row = 7 |
| 4 | 9 | 5 | 7 | - | true | - | 0 | 0 | Check: row >= 0 && row <= 4 = false |
| 4 | 10 | 5 | 7 | - | false | - | 0 | 0 | validInput = false |
| 4 | 11 | 5 | 7 | - | false | - | 0 | 0 | WRITE = "Input a number between 0 and 4" |
| 4 | 12 | 5 | - | - | false | - | 0 | 0 | Loop back, WRITE = "Input a row (0-4):" |
| 4 | 13 | 5 | 2 | - | true | - | 0 | 0 | READ input = "2", row = 2 |
| 4 | 14 | 5 | 2 | - | true | - | 0 | 0 | Row valid, WRITE = "Input a column (0-4):" |
| 4 | 15 | 5 | 2 | - | true | - | 0 | 0 | READ input = "-1" |
| 4 | 16 | 5 | 2 | -1 | true | - | 0 | 0 | TryParse succeeds, column = -1 |
| 4 | 17 | 5 | 2 | -1 | true | - | 0 | 0 | Check: column >= 0 && column <= 4 = false |
| 4 | 18 | 5 | 2 | -1 | false | - | 0 | 0 | validInput = false |
| 4 | 19 | 5 | 2 | -1 | false | - | 0 | 0 | WRITE = "Input a number between 0 and 4" |
| 4 | 20 | 5 | 2 | - | false | - | 0 | 0 | Loop back, WRITE = "Input a column (0-4):" |
| 4 | 21 | 5 | 2 | 1 | true | ➖ | 0 | 0 | READ input = "1", column = 1, valid |
| 4 | 22 | 5 | 2 | 1 | true | ➖ | 0 | 0 | WRITE = "Digging in coordinates (2,1)..." |
| 4 | 23 | 5 | 2 | 1 | true | 🪙 | 35 | 35 | matrixMap[2,1] = 🪙, bits = 35, totalBits = 35 |
| 4 | 24 | 5 | 2 | 1 | true | 🪙 | 35 | 35 | WRITE = "You struck a gold! Bits found: 35" |
| 4 | 25 | 5 | 2 | 1 | true | 🪙 | 35 | 35 | Display updated map |
| 5 | - | 4 | - | - | false | - | 35 | 35 | attempts--, continue with remaining attempts... |
| 6 | - | 0 | - | - | false | - | 35 | 35 | (After completing remaining 4 valid digs) |
| 7 | - | 0 | - | - | false | - | 35 | 35 | WRITE = "You have found a total of [totalBits] bits in this mine" |