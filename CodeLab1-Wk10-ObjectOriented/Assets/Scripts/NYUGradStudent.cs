public class NYUGradStudent : NYUStudent
{
    public string almaMater;
    
    public override string GetRecord()
    {
        string result = base.GetRecord();
        result += "\nAlma Mater: " + almaMater;
            
        return result;

    }
}

