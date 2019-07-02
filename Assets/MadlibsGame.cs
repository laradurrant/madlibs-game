using UnityEngine;

public class MadlibsGame : MonoBehaviour
{
    /// <summary>
    ///  This is a Madlimbs Game!!! (don't copywrite us)
    /// </summary>
    /// 
    // These are strings
    private string noun1;
    private string personname;
    private string noun2;
    private string noun3;
    private string occupation;
    private string shape;

    public UnityEngine.UI.Text storyText;
    public UnityEngine.UI.Text helpText;
    public UnityEngine.UI.InputField[] field;
    public GameObject storyBox;
    public GameObject inputBoxes;

    void Start()
    {
        noun1 = "";
        personname = "";
        noun2 = "";
        noun3 = "";
        occupation = "";
        shape = "";
    
        storyBox.SetActive(false);
        inputBoxes.SetActive(true);
    }

    void ClearInputFields()
    {
        for (int i = 0; i < field.Length; i++)
        {
            field[i].text = "";
        }
    }

    public void SetNoun1(string word)
    {
        noun1 = word;
    }

    public void SetPersonName(string word)
    {
        personname = word;
    }

    public void SetNoun2(string word)
    {
        noun2 = word;
    }

    public void SetNoun3(string word)
    {
        noun3 = word;
    }

    public void SetOccupation(string word)
    {
        occupation = word;
    }

    public void SetShape(string word)
    {
        shape = word;
    }

    public string GetNoun1()
    {
        return noun1;
    }

    public string GetNounParticle()
    {
         string word = GetNoun1();

       if(word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
        {
            return "an";
        }
        else
        {
            return "a";
        }
    }

    public string GetName()
    {
        return personname;
    }

    public string GetNoun2()
    {
        return noun2;
    }

    public string GetNoun3()
    {
        return noun3;
    }

    public string GetOccupation()
    {
        return occupation;
    }

    public string GetShape()
    {
        return shape;
    }

    private bool CheckFilledOut()
    {
        if(GetNoun3() == "")
        {
            return false;
        }
        else if(GetName() == "")
        {
            return false;
        }
        else if(GetNoun2() == "")
        {
            return false;
        }
        else if(GetNoun1() == "")
        {
            return false;
        }
        else if (GetOccupation() == "")
        {
            return false;
        }
        else if (GetShape() == "")
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public void DisplayStoryUI()
    {
        if (CheckFilledOut())
        {
            helpText.text = "";
            /*
             * storyText.text = "Once upon a time, there was a " + GetNoun1() + ". " +
                "Its personname was " + GetName() + ". " +
                "One day our hero " + GetName() + " decided they wanted to do stuff. " +
                "It was important stuff. Stuff that only a " + GetNoun1() + " could do. " +
                "So they teamed up with another " + GetNoun1() + " named " + GetNoun2() + " and solved crime. " +
                "They formed a pretty " + GetNoun3() + " team. " +
                "The End.";
            
            storyText.text =
            "There were lots of things. Big things, small things, big-small things, even smaller things, even bigger things, even bigger smaller big small things, also " + GetNoun3() + "things." +
                 " One great hero, errr, ball of cheese, that goes by the personname " + GetName() + " discovered these things." +
                 " It was to their horror that " + GetNoun2() + " Also found these things. It was " + GetNounParticle()  + GetNoun1() + "-(e)y play-musical-real-life-dramatic applause(event-expiriment)." +
                 "Do I make sneeze?";
                 */
            storyText.text =
            GetName() + " is a normal " + GetOccupation() + ". Then, one day, " + GetNounParticle() + " " + GetNoun1() +
            " explodes, causing " + GetNounParticle() + " " + GetNoun2() + " to blow up, and a nearby " + GetNoun3() + " erupts" +
            " into a " + GetShape() + " of flames.";
           

            storyBox.SetActive(true);
            inputBoxes.SetActive(false);
        }
        else
        {
            helpText.text = "You didn't enter all of the words!";
        }
    }

    public void ResetStory()
    {
        storyText.text = "";
        SetNoun3("");
        SetPersonName("");
        SetNoun2("");
        SetNoun1("");
        SetShape("");
        SetOccupation("");
        ClearInputFields();

        storyBox.SetActive(false);
        inputBoxes.SetActive(true);
    }
}
