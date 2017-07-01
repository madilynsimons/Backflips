AttackList.txt contains every possible attack in the game.
This will prevent any enemy, character, etc from using any 
attacks that aren’t in the game.  It also standardizes all
possible attacks.

The Attack Manager will create a new AttackObject for each line
according to the following format:

TITLE PP SIZE

string TITLE will represent what the attack is called
int PP is how many times the move can be used
int SIZE is how many “slots” this attack will take up
NB: SIZE must be a 0 (null), 1, 2, 3, 4, or 6

See AttackList.txt for examples