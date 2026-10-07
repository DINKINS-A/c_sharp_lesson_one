using PrimitiveDataTypesAndVariables;
/*============================
 * Lesson 1: Primitives and Variables
 =============================*/

/*
 * ==========
 * PRIMITIVES
 * ==========
 * Motivation: We need some way of representing different types of data in our code.
 * Luckily, the developers of C# have done this for us.
 * The are called Primitives Data Types becaue they are native (built-into) whatever language you're using.
 * You will come across the same types of primitives across many languages.
 * We don't think about it much, but how was the number 1 defined. Humans have collectively agreed upon the meaning of this.
 */

//Integral Primitive Data Types
//Represent Integers
//byte, short, int, long, ubyte, ushort, uint, ulong.
//Examples: 0, 123, 2789, -314159

//Floating-Point Numeric Types
//Represents numbers with a floating point
//float, double, decimal
//Examples: 3.151926, 2.178, 0.0123

//Characters
//Represent single alphanumeric characters or symbols
//Examples: 'c', '0', 'A', '$'

//Booleans
//Represent True/False values


/*
 * =========
 * Variables
 * =========
 * Motivation: We need some way of storing the our game's data. For example, if we fail to keep track of the player's health
 * then how would we know when the player has died? A similar example can be thought up for other resources:
 * (Mana, Ammo, Gold, etc.)
*/

//A variable is a box that stores our data.
//The box can only hold a particular type of data.
//For exmample: We can have boxes for ints, floats, or even booleans
//What do variables look like?
int playerHealth = 10;
// Here you can see we are using the int data type
// We have created a new variable, of type integer, and given it the name playerHealth
// We need to name our box (variable), otherwise we cannot resuse it later.
// The above statement can be broken down into the following statements:
// [data type] [variable name] = [value];
// The assignment operator (=) just puts the variable in the box.
// The line is terminated by a semicolon. This tells the compiler when the "sentence" ends.
double PI = 3.14159;
bool iLoveCSharp = true;
long tankArmor = 123456789;

/*
 * Functions
 * In our game, we need to perform various actions. Like decrease the player's health whenever they are shot.
 * 
 */

int addTwoNumbers(int a, int b)
{
    int sum = b + a;
    Console.WriteLine(sum);
    return sum;
}

Player player_one = new Player(10, "Ava", 20);
Player player_two = new Player(11, "Kai", 19);
Player player_three = new Player(12, "Cat", 190);
Player player_four = new Player(1234532643, "Kuro no Kami Sama aka M00D aka Ahmad", 54231);

player_one.shoot();
player_two.shoot();
player_three.shoot();
player_one.shoot();

int sum = addTwoNumbers(10, 12);
Console.WriteLine(sum);
Console.Write(sum);
Console.Write(sum);







