# Acceptance Criteria

As a user I would like to be able to continuously provide a list of words to be unscrambled either manually or as a file containing them.

The process of unscrambling the words will be based on an external file (which is a list of words per line)

The user should have access to this file and could modify, add or remove words as necessary.

The process of comparing the words together should not care for any language specific rules and should be case insensitive.

You can get creative with the information being displayed to the user as long as it directly conveys the meaning of what the user needs to do based on the acceptance criteria.

Example:

| Input | Output |
| F - file/M - manual | For F - ask for filename For M - ask for word or words separated by commas |
| OMRE, ctA | MATCH FOUND FOR OMRE: more MATCH FOUND FOR OMRE: rome MATCH FOUND FOR ctA: cat MATCH FOUND FOR ctA: act |
| continue? Y/N | For Y - start over For N - close application |

| Word List |
| here |
| there |
| somewhere |
| something |
| someone |
| cat |
| act |
| more |
| rome |