# Chapter 7: Decode Ancient Scrolls

Normal: All scrolls successfully decoded

| Instruction | Iteration | scroll | vowelsCounter | arrayDecoded[0] | arrayDecoded[1] | arrayDecoded[2] | Output |
|-------------|-----------|--------|---------------|-----------------|-----------------|-----------------|--------|
| 1 | - | - | 0 | false | false | false | - |
| 2 | - | - | 0 | false | false | false | WRITE = "You have found the ancient scrolls, but they are encrypted." |
| 3 | - | - | 0 | false | false | false | WRITE = "1. When the moon is full, the arcana will be the means of which all will be revealed." |
| 4 | - | - | 0 | false | false | false | WRITE = "2. The magic in the inside is the strenght to conquer the fear of of death." |
| 5 | - | - | 0 | false | false | false | WRITE = "3. Spells: Diarahan ✨ 4, Panta rei 🌪️ 6, Myriad truths ☄️ 9, Matarukaja 💪 3." |
| 6 | - | - | 0 | false | false | false | WRITE = "Select a method of decoding:" |
| 7 | - | - | 0 | false | false | false | WRITE = "1. Decipher spell (remove spaces).\n2. Count magical runes (vowels).\n3. Extract secret code (numbers)." |
| 8 | - | 1 | 0 | false | false | false | READ = 1 |
| 9 | - | 1 | 0 | false | false | false | WRITE = "Decoded spell: Whenthemoonisfull,thearcana..." |
| 10 | - | 1 | 0 | true | false | false | arrayDecoded[0] = true |
| 11 | - | - | 0 | true | false | false | WRITE = "Select a method of decoding:" |
| 12 | - | 2 | 0 | true | false | false | READ = 2 |
| 13 | 1 | 2 | 0 | true | false | false | vowelsCounter = 0 |
| 13 | 2 | 2 | 1 | true | false | false | vowelsCounter++ (letter = 'e') |
| 13 | 3 | 2 | 2 | true | false | false | vowelsCounter++ (letter = 'a') |
| 13 | ... | 2 | ... | true | false | false | ... |
| 13 | n | 2 | 27 | true | false | false | vowelsCounter = 27 |
| 14 | - | 2 | 27 | true | false | false | WRITE = "27 magical runes (vowels) found." |
| 15 | - | 2 | 27 | true | true | false | arrayDecoded[1] = true |
| 16 | - | - | 27 | true | true | false | WRITE = "Select a method of decoding:" |
| 17 | - | 3 | 27 | true | true | false | READ = 3 |
| 18 | - | 3 | 27 | true | true | false | WRITE = "The secret code is: " |
| 19 | 1 | 3 | 27 | true | true | false | letter = 'S' (no match) |
| 19 | 2 | 3 | 27 | true | true | false | letter = 'p' (no match) |
| 19 | ... | 3 | 27 | true | true | false | ... |
| 19 | n | 3 | 27 | true | true | false | letter = '4', WRITE = "4" |
| 19 | n+1 | 3 | 27 | true | true | false | letter = '6', WRITE = "6" |
| 19 | n+2 | 3 | 27 | true | true | false | letter = '9', WRITE = "9" |
| 19 | n+3 | 3 | 27 | true | true | false | letter = '3', WRITE = "3" |
| 20 | - | 3 | 27 | true | true | true | arrayDecoded[2] = true |
| 21 | - | - | 27 | true | true | true | arrayDecoded[0] == true && arrayDecoded[1] == true && arrayDecoded[2] == true ? = true |
| 22 | - | - | 27 | true | true | true | WRITE = "Congratulations, you have succesfully decoded all the ancient scrolls..." |

Limit: Decode only one scroll

| Instruction | Iteration | scroll | vowelsCounter | arrayDecoded[0] | arrayDecoded[1] | arrayDecoded[2] | Output |
|-------------|-----------|--------|---------------|-----------------|-----------------|-----------------|--------|
| 1 | - | - | 0 | false | false | false | - |
| 2 | - | - | 0 | false | false | false | WRITE = "You have found the ancient scrolls, but they are encrypted." |
| 3 | - | - | 0 | false | false | false | WRITE = "1. When the moon is full..." |
| 4 | - | - | 0 | false | false | false | WRITE = "2. The magic in the inside..." |
| 5 | - | - | 0 | false | false | false | WRITE = "3. Spells: Diarahan..." |
| 6 | - | - | 0 | false | false | false | WRITE = "Select a method of decoding:" |
| 7 | - | - | 0 | false | false | false | WRITE = "1. Decipher spell (remove spaces).\n2. Count magical runes (vowels).\n3. Extract secret code (numbers)." |
| 8 | - | 1 | 0 | false | false | false | READ = 1 |
| 9 | - | 1 | 0 | false | false | false | WRITE = "Decoded spell: Whenthemoonisfull,thearcana..." |
| 10 | - | 1 | 0 | true | false | false | arrayDecoded[0] = true |
| 11 | - | - | 0 | true | false | false | WRITE = "Select a method of decoding:" |
| 12 | - | 0 | 0 | true | false | false | READ = 0 (exit by user - loop exits if scrollInput remains true) |
| 13 | - | - | 0 | true | false | false | arrayDecoded[0] == true && arrayDecoded[1] == true && arrayDecoded[2] == true ? = false |
| 14 | - | - | 0 | true | false | false | No congratulations message displayed |

Error: Invalid input

| Instruction | Iteration | scroll | vowelsCounter | arrayDecoded[0] | arrayDecoded[1] | arrayDecoded[2] | scrollInput | Output |
|-------------|-----------|--------|---------------|-----------------|-----------------|-----------------|-------------|--------|
| 1 | - | - | 0 | false | false | false | true | - |
| 2 | - | - | 0 | false | false | false | true | WRITE = "You have found the ancient scrolls, but they are encrypted." |
| 3 | - | - | 0 | false | false | false | true | WRITE = "1. When the moon is full..." |
| 4 | - | - | 0 | false | false | false | true | WRITE = "2. The magic in the inside..." |
| 5 | - | - | 0 | false | false | false | true | WRITE = "3. Spells: Diarahan..." |
| 6 | - | - | 0 | false | false | false | true | WRITE = "Select a method of decoding:" |
| 7 | - | - | 0 | false | false | false | true | WRITE = "1. Decipher spell (remove spaces).\n2. Count magical runes (vowels).\n3. Extract secret code (numbers)." |
| 8 | - | - | 0 | false | false | false | true | READ = "abc" (invalid input) |
| 9 | - | - | 0 | false | false | false | true | FormatException caught |
| 10 | - | - | 0 | false | false | false | false | scrollInput = false |
| 11 | - | - | 0 | false | false | false | false | WRITE = "Input a number between 1 and 3." |
| 12 | - | - | 0 | false | false | false | false | scrollInput != true ? = true (loop exits) |
| 13 | - | - | 0 | false | false | false | false | arrayDecoded[0] == true && arrayDecoded[1] == true && arrayDecoded[2] == true ? = false |
| 14 | - | - | 0 | false | false | false | false | No congratulations message displayed |