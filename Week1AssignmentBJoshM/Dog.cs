public class Dog : Pet, ITalkable
{
    private bool _friendly;

    public Dog(bool friendly, string name) : base(name)
    {
        this._friendly = friendly;
    }

    public bool IsFriendly() {return _friendly;}

    public string Talk() {return "Bark";}

    public override string ToString()
    {
        return "Dog: " + "name=" + _name + " friendly=" + _friendly;
    }
}