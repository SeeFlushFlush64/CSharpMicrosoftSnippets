string myName = "Michael";
int daysOfPreparation = 5;
string jobName = "";
switch (daysOfPreparation)
{
    case 0:
    case 30:
        jobName = "Unemployed";
        break;
    case 31:
    case 60:
        jobName = "Tech Support";
        break;
    case 61:
    case 90:
        jobName = "Ju
        nior Developer";
        break;
    case 3:
        jobName = "Senior Developer";
        break;
    case 4:
        jobName = "Product Manager";
        break;
    default:
        jobName = "Job Hopper";
        break;
}
Console.WriteLine($"{myName}\n{jobName}");