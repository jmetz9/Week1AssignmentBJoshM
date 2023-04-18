public class Teacher : Person, ITalkable
{
    private int _age;

    public Teacher(int age, string name) : base(name)
    {
        this._age = age;
    }

    public int GetAge() {return _age;}

    public void SetAge(int age) {this._age = age;}

    public string Talk() {return "Don't forget to do the assigned reading!";}
}