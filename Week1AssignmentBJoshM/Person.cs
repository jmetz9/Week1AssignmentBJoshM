public abstract class Person
{
    private string _name;

    public Person(string name){this._name = name;}

    public string GetName(){return _name;}

    public void SetName(string name){this._name = name;}
}