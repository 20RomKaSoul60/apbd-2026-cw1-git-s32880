namespace Tutorial2;

public class StaticHelper
{

    public string name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int age{
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }


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