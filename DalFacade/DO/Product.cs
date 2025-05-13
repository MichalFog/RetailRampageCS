namespace DO;
/// <summary>
/// 
/// </summary>
/// <param name="id">מספר מזהה ייחודי </param>
/// <param name="product_name">שם המוצר</param>
/// <param name="price">מחיר</param>
/// <param name="amount">כמות במלאי</param>
public record Product
    (
    int id,
    string? product_name,
    Category? category,
    double? price,
    int? amount
    )
{
    public Product():this(0,"",null,0,0)
    {
        
    }
}
