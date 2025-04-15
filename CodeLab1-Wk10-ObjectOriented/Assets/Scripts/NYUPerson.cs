using UnityEngine;

public class NYUPerson
{
    public string netID;
    public string name;
    public long nNumber;
    public float age;
    
    // an empty or default CONSTRUCTOR
    //required if you're going to use any other constructors and still want ppl to be able to use an empty one
    public NYUPerson()
    {
    }
    
    // Constructor that takes arguments
    public NYUPerson(string netID, string name, long nNumber, float age)
    {
        this.name = name;
        this.netID = netID;
        this.nNumber = nNumber;
        this.age = age;
        
    }
    
    //virtual function means this function can be overwritten
    //so other subclasses and call  different version of this function
    public virtual string GetRecord()
    {
        string result = "Name: " + name + "\n" +
                        "Net ID: " + netID + "\n" +
                        "Age: " + age + "\n" +
                        "N Number: " + nNumber + "\n";
        return result;
    }

}
