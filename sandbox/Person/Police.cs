class Police : Person
{
    private string _weapons;

    public Police(string firstName, string LastName, int age, double weight, string _weapons) : base (firstName, LastName, age, weight)
    {
        _weapons = _weapons;
    }
}