namespace DO;
/// <summary>
/// 
/// </summary>
/// <param name="Tz">ת"ז</param>
/// <param name="Costumer_name">שם הלקוח</param>
/// <param name="Address">כתובת</param>
/// <param name="phone">טלפון</param>
public record Customer
    (
    int Tz,
    string? Costumer_name,
    string? Address,
    string? phone
    )
{
    public Customer() : this(0,"", "", "")
    {

    }
}
