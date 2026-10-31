
R2 : Find the problems with this design when many orders must be exported, and list them in ANSWERS.md.

Problem 1 :
Thread.Sleep(800); in GetPendingOrders Method.
Explanation : using Thread.Sleep will block the thread .

Problem 2 :
Thread.Sleep(400); in GetOrderById Method.
Explanation : using Thread.Sleep will block the thread .

Problem 3 :
Thread.Sleep(300); in ReadProfile Method.
Explanation : using Thread.Sleep will block the thread .

Problem 3 :
string text = File.ReadAllText(path); in ReadProfile Method.
Explanation : using File.ReadAllText() will take space from memory more than using fileStream to read the file .

Problem 4 :
int.Parse(parts[0]); in ReadProfile Method.
Explanation : using int.Parse() will make exception if the parse failed .

Problem 5 :
Thread.Sleep(300); in WriteInvoice Method.
Explanation : using int.Parse() will make exception if the parse failed .

Problem 6 :
File.WriteAllText(path, body); in WriteInvoice Method.
Explanation : using File.WriteAllText() will take space from memory more than using fileStream to write the file .

R4 : Write in ANSWERS.md what you changed and why, with the console output before and after.

Change 1: I replaced File.WriteAllText() with StreamWriter and used a foreach loop to create files and write their contents.
Why : because File.WriteAllText() take more space from memory but StreamWriter take less .
Console Output Before : no changes
Console Output After : no changes

Change 2: I replaced Thread.Sleep() with Task.Delay() .
Why : because Thread.Sleep() block the thread but Task.Delay() not.

Change 3: I replaced File.ReadAllText() with StreamReader .
Why : because File.ReadAllText() take more space from memory but StreamReader take less.

Change 4: I replaced int.Parse with int.TryParse .
Why : because int.Parse will make exception if parsing failed but int.TryParse will not make exception.









