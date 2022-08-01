using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{


    string heroname = "memo";
    int herohieght = 155;
    int heroage = 20;
    string herosuperpower = "lovely";

    string villianname = "drakula";
    int villianhieght = 164;
    int villiainage = 16;
    string villiansuperpower = "evil";

   


   











    // Start is called before the first frame update
    void Start()
    {int agedifference = 20 - 16;
        print("I am" + heroname + "I am" + herohieght + "feet tall." + "I am only" + heroage + "years old." + "My superpower is" + herosuperpower);
        print("I am" + villianname + "I am" + villianhieght + "feet tall." + "I am only" + villiainage + "years old." + "My superpower is" + villiansuperpower);
        print("Between" + heroname + "and" + villianname + "there is a" + agedifference + "year age difference");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
