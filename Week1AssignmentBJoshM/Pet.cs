public abstract class Pet
{
    protected string _name;

    public Pet(string name) {this._name = name;}

    public string GetName() {return _name;}
}