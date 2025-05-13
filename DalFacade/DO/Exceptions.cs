namespace DO;

[Serializable]
public class DalNotFound : Exception
{
    public DalNotFound(string message) : base(message) { }
}


[Serializable]
public class DalIdExsist : Exception
{
    public DalIdExsist(string message) : base(message) { }
}

