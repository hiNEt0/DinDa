namespace table;

public interface IActive
{
    public int range { get; set; }
    public void DoDamage();
    public void SpendAction();
}