string permission = "Admin|Manager";
int level = 55;
bool admin = permission.Contains("Admin");
bool manager = permission.Contains("Manager");
string userPrompt = "";
if (admin) 
{
    userPrompt = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.";
}
else if (manager)
{
    userPrompt = level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
}
else
{
    userPrompt = "You do not have sufficient privileges.";
}
// if (admin && level > 55)
// {
//     userPrompt = "Welcome, Super Admin user.";
// }
// else if (admin && level <= 55)
// {
//     userPrompt = "Welcome, Admin user.";
// }
// else if (manager && level >= 20)
// {
//     userPrompt = "Contact an Admin for access.";
// }
// else if (manager && level < 20)
// {
//     userPrompt = "You do not have sufficient privileges.";
// }
// else
// {
//     userPrompt = "You do not have sufficient privileges.";
// }

Console.WriteLine(userPrompt);