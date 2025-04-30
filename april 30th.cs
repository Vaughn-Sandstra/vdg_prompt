i learned how to store the avarage of a thing using a variable.

decimal sophiaScore;
decimal nicolasScore;
decimal zahirahScore;
decimal jeongScore;

decimal nicolasScore = nicolasSum / currentAssignments;
decimal zahirahScore = zahirahSum / currentAssignments;
decimal jeongScore = jeongSum / currentAssignments;

to calculate the score you must divide the variable by the other one, leading to the average. to display each students current score you just subsitute.

Console.WriteLine("Sophia: " + sophiaScore);
Console.WriteLine("Nicolas: " + nicolasScore);
Console.WriteLine("Zahirah: " + zahirahScore);
Console.WriteLine("Jeong: " + jeongScore);

if you want to add a letter to these you just add one. (Ex.):

Console.WriteLine("Sophia: " + sophiaScore + " A");
Console.WriteLine("Nicolas: " + nicolasScore + " B");
Console.WriteLine("Zahirah: " + zahirahScore + " B");
Console.WriteLine("Jeong: " + jeongScore + " A");
