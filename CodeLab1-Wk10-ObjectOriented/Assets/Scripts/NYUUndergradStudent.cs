public class NYUUndergradStudent : NYUStudent
{
    public string major;
    
    public override string GetRecord()
    {
        string result = base.GetRecord();
        result += "\nMajor: " + major;
            
        return result;

    }
}

