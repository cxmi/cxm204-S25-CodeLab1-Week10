using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NYUPerson mattParker = new NYUPerson();
        mattParker.name = "Matt Parker";
        mattParker.nNumber = 12342344;
        mattParker.netID = "mp612";
        mattParker.age = 42;
        
        Debug.Log(mattParker.GetRecord());

        //NYUPerson rio = new NYUStudent();
         NYUStudent rio = new NYUStudent();
        rio.name = "Rio";
        rio.nNumber = 123482498423;
        rio.netID = "rr123";
        rio.age = 45;
        rio.gradYear = 2026;
        
        Debug.Log(rio.GetRecord());
        
        //((NYUStudent)rio).gradYear = 100000;

        NYUPerson Frank = new NYUPerson(
            "f42", 
            "Frank", 
            231323, 
            100);
        
        Debug.Log(Frank.GetRecord());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
