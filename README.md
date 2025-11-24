# Chapter 1: Train your Wizard

Normal: wizardName = Arion,
day1: hour = 5, power = 3 
day2: hour = 2, power = 4   
day3: hour = 7, power = 6   
day4: hour = 1, power = 5   
day5: hour = 3, power = 2
totalPower = 20 -> title = Noob

| Instruction | Iteration | day | hour  | power  | totalHour  | totalPower  | Output  |
|-------------|-----------|-----|-------|--------|------------|-------------|---------|
| 1           | -         | -   | -     | -      | -          | -           | WRITE = "Enter your wizard's name:" |
| 2           | 1         | -   | -     | -      | -          | -           | User inputs "Arion" |
| 2           | 2         | -   | -     | -      | -          | -           | WRITE = "Your wizard's name is: Arion" |
| 3           | 1         | 1   | 5     | 3      | 5          | 3           | WRITE = "Day 1: Arion meditated for 5 hours and gained 3 power points." |
| 3           | 2         | 1   | 5     | 3      | 5          | 3           | WRITE = "Arion has meditated for a total of 5 hours and gained 3 power points." |
| 3           | 3         | 2   | 2     | 4      | 7          | 7           | Day 2 training output |
| 3           | 4         | 3   | 7     | 6      | 14         | 13          | Day 3 training output |
| 3           | 5         | 4   | 1     | 5      | 15         | 18          | Day 4 training output |
| 3           | 6         | 5   | 3     | 2      | 18         | 20          | Day 5 training output |
| 4           | 1         | -   | -     | -      | 18         | 20          | WRITE = "You still confuse your wand with a spoon" |
| 4           | 2         | -   | -     | -      | 18         | 20          | WRITE = "Title: Zyn the bugged" |


Limit: totalPower = 40 >= 40 -> title Master.

| Instruction | Iteration | day | hour  | power  | totalHour  | totalPower  | Output  |
|-------------|-----------|-----|-------|--------|------------|-------------|---------|
| 1           | -         | -   | -     | -      | -          | -           | WRITE = "Enter your wizard's name:" |
| 2           | 1         | -   | -     | -      | -          | -           | User inputs "Arion" |
| 3           | 1         | 1   | 4     | 10     | 4          | 10          | Day 1 output |
| 3           | 2         | 2   | 3     | 8      | 7          | 18          | Day 2 output |
| 3           | 3         | 3   | 6     | 7      | 13         | 25          | Day 3 output |
| 3           | 4         | 4   | 1     | 9      | 14         | 34          | Day 4 output |
| 3           | 5         | 5   | 2     | 6      | 16         | 40          | Day 5 output |
| 4           | 1         | -   | -     | -      | 16         | 40          | WRITE = "You have achieved the Master of Arcanes rank!" |
| 4           | 2         | -   | -     | -      | 16         | 40          | WRITE = "Title: ITB-Wizard the Grey" |

Error: Name with spaces wizardName = Dark Mage

| Instruction | Iteration | day | hour  | power  | totalHour  | totalPower  | Output  |
|-------------|-----------|-----|-------|--------|------------|-------------|---------|
| 1           | -         | -   | -     | -      | -          | -           | WRITE = "Enter your wizard's name:" |
| 2           | 1         | -   | -     | -      | -          | -           | User inputs "Dark Mage" |
| 2           | 2         | -   | -     | -      | -          | -           | WRITE = "Input a name without spaces." |
| 2           | 3         | -   | -     | -      | -          | -           | WRITE = "Input a name without spaces." |
| 2           | 4         | -   | -     | -      | -          | -           | User inputs "Darkmage" (valid) |
| 2           | 5         | -   | -     | -      | -          | -           | WRITE = "Your wizard's name is: Darkmage" |