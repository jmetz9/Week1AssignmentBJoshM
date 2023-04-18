public class Cat : Pet, ITalkable
{
    private int _miceKilled;

    public Cat(int miceKilled, string name) : base(name)
    {
        this._miceKilled = miceKilled;
    }

    public int GetMiceKilled() {return _miceKilled;}

    public void AddMouse() {_miceKilled++;}

    public string Talk() {return "Meow";}

    public override string ToString()
    {
        return "Cat: " + "name=" + _name + " miceKilled=" + _miceKilled;
    }
}