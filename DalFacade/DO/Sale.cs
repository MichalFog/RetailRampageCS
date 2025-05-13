namespace DO;
/// <summary>
/// 
/// </summary>
/// <param name="id">מספר מזהה</param>
/// <param name="amount_for_sale">כמות נדרשת לקבלת המבצע</param>
/// <param name="price_sale">מחיר כולל במבצע</param>
/// <param name="for_who">המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדוןמחיר כולל במבצע</param>
/// <param name="start_sale">תחילת המבצע</param>
/// <param name="end_sale">סיום המבצע</param>
public record Sale
    (
    int id,
    int product_id,
    int? amount_for_sale,
    double? price_sale,
    bool? for_who,
    DateTime? start_sale,
    DateTime? end_sale
    )
{
    public Sale() :this(0,0,0,0,false,null,null)
    {
        
    }
}
