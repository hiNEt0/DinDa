namespace table;

public interface Effect
{
    public int Duration { get; set; }
    public void ApplyEffect();
}