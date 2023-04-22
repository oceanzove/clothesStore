using System.Globalization;

namespace clotchstore;

public class Product
{
    private string _name;
    private string _dsescription;
    private string _price;
    private string _size;
    private string _color;

    public void productCreate(string? name, string? dsescription, string price, string? size, string? color)
    {
        this._name = name;
        this._dsescription = dsescription;
        this._price = price;
        this._size = size;
        this._color = color;
    }
}