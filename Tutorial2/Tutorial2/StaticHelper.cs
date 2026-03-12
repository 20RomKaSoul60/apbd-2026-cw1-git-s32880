namespace Tutorial2;

public class StaticHelper
{

    public string name;
    public int age;


    private string problem = "";


    public void describeProblem()
    {
        problem = Console.ReadLine();
        if (problem == "")
        {
            throw new Exception("Message is empty");
        }

    }






}