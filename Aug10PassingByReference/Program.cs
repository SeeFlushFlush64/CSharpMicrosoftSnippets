int num = 10;
string name = "Michael";
UpdateNumber(name: ref name, num: ref num);
Console.Write(num);
Console.Write(name);
void UpdateNumber(ref int num, ref string name) {
    num = 99;
    name = "Rhey";
}