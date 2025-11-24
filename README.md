# Chapter 2: Increasing your Level

Normal: level = 1

| Instruction | Iteration | level  | monsterIndex  | monsterName       | health  | damage  | Output  |
|-------------|-----------|--------|---------------|-------------------|---------|---------|---------|
| 1           | -         | 1      | rnd           | rnd               | -       | -       | Random monster selected |
| 2           | 1         | 1      | 2             | Green Slime 🟢    | 10      | -       | WRITE = "A wild Green Slime 🟢 appears! Rolling dice..." |
| 2           | 2         | 1      | 2             | Green Slime 🟢    | 10      | 3       | WRITE = "The Green Slime 🟢 has 10 HP left." |
| 2           | 3         | 1      | 2             | Green Slime 🟢    | 7       | 3       | Dice ASCII for roll 3 |
| 2           | 4         | 1      | 2             | Green Slime 🟢    | 7       | 3       | WRITE = "You rolled a 3!" |
| 2           | 5         | 1      | 2             | Green Slime 🟢    | 7       | 3       | WRITE = "The monster takes 3 damage." |
| 2           | 6         | 1      | 2             | Green Slime 🟢    | 7       | -       | WRITE = "Press enter to continue" |
| 2           | 7         | 1      | 2             | Green Slime 🟢    | 7       | 4       | WRITE = "The Green Slime 🟢 has 7 HP left." |
| 2           | 8         | 1      | 2             | Green Slime 🟢    | 3       | 4       | Dice ASCII for roll 4 |
| 2           | 9         | 1      | 2             | Green Slime 🟢    | 3       | 4       | WRITE = "You rolled a 4!" |
| 2           | 10        | 1      | 2             | Green Slime 🟢    | 3       | 4       | WRITE = "The monster takes 4 damage." |
| 2           | 11        | 1      | 2             | Green Slime 🟢    | 3       | -       | WRITE = "Press enter to continue" |
| 2           | 12        | 1      | 2             | Green Slime 🟢    | 3       | 5       | WRITE = "The Green Slime 🟢 has 3 HP left." |
| 2           | 13        | 1      | 2             | Green Slime 🟢    | -2      | 5       | Dice ASCII for roll 5 |
| 2           | 14        | 1      | 2             | Green Slime 🟢    | -2      | 5       | WRITE = "You rolled a 5!" |
| 2           | 15        | 1      | 2             | Green Slime 🟢    | -2      | 5       | WRITE = "The monster takes 5 damage." |
| 2           | 16        | 1      | 2             | Green Slime 🟢    | -2      | -       | WRITE = "Press enter to continue" |
| 3           | 1         | 2      | 2             | Green Slime 🟢    | -2      | -       | level++ |
| 3           | 2         | 2      | 2             | Green Slime 🟢    | -2      | -       | WRITE = "You have defeated the monster, your level increases to level 2." |

Limit: level = 5

| Instruction | Iteration | level | monsterIndex | monsterName | health | damage | Output |
|-------------|-----------|--------|---------------|--------------|---------|---------|---------|
| 1           | -         | 5      | -             | -            | -       | -       | Player selects option 2 (Increase LVL) |
| 2           | 1         | 5      | -             | -            | -       | -       | Condition level >= 5 is TRUE |
| 2           | 2         | 5      | -             | -            | -       | -       | WRITE = "You have achieved max level." |
| 2           | 3         | 5      | -             | -            | -       | -       | Program waits for ENTER |
