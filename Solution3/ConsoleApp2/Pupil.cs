namespace ConsoleApp2;

public class Pupil
{
    
    public virtual double Studying { get; set; } = 0;
    public virtual double Reading { get; set; } = 0;
    public virtual double Writing { get; set; } = 0;
    public virtual double Relaxing { get; set; } = 0;
    public virtual void Study()
    {
        if (Studying < 5)
        {
            Studying++;
        } 
    }

    public virtual void Read()
    {
        if (Reading < 5)
        {
            Reading++;
        } 
    }

    public virtual void Write()
    {
        if (Writing < 5)
        {
            Writing++;
        } 
    }

    public virtual void Relax()
    {
        if (Relaxing < 5)
        {
            Relaxing++;
        } 
    }
}