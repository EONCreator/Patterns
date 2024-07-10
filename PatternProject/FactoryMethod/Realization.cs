namespace PatternProject.FactoryMethod;

public class DateEditor : PropertyEditor<DateTime>
{
    private DateTime date;
    
    public override void Edit(DateTime data)
    {
        date = data;
    }

    public DateTime Date => date;
}
