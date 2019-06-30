using UnityEngine;

public class MadlibsGame : MonoBehaviour
{

    private string noun;
    private string name1;
    private string name2;
    private string adjective;

    public UnityEngine.UI.Text storyText;
    public UnityEngine.UI.Text helpText;
    public UnityEngine.UI.InputField[] field;
    public GameObject storyBox;
    public GameObject inputBoxes;

    void Start()
    {
        noun = "";
        name1 = "";
        name2 = "";
        adjective = "";
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

    public void SetNoun(string word)
    {
        noun = word;
    }

    public void SetName1(string word)
    {
        name1 = word;
    }

    public void SetName2(string word)
    {
        name2 = word;
    }

    public void SetAdjective(string word)
    {
        adjective = word;
    }

    public string GetNoun()
    {
        return noun;
    }

    public string GetName1()
    {
        return name1;
    }

    public string GetName2()
    {
        return name2;
    }

    public string GetAdjective()
    {
        return adjective;
    }

    private bool CheckFilledOut()
    {
        if(GetAdjective() == "")
        {
            return false;
        }
        else if(GetName1() == "")
        {
            return false;
        }
        else if(GetName2() == "")
        {
            return false;
        }
        else if(GetNoun() == "")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void DisplayStory()
    {
        Debug.Log("Once upon a time, there was a " + GetNoun() + ".");
        Debug.Log("One day our hero " + GetName1() + " decided they wanted to do stuff.");
        Debug.Log("So they teamed up with " + GetName2() + " and solved crime.");
        Debug.Log("They formed a pretty " + GetAdjective() + " team.");
    }

    public void DisplayStoryUI()
    {
        if (CheckFilledOut())
        {
            helpText.text = "";
            storyText.text = "Once upon a time, there was a " + GetNoun() + ". " +
                "Its name was " + GetName1() + ". " +
                "One day our hero " + GetName1() + " decided they wanted to do stuff. " +
                "It was important stuff. Stuff that only a " + GetNoun() + " could do. " +
                "So they teamed up with another " + GetNoun() + " named " + GetName2() + " and solved crime. " +
                "They formed a pretty " + GetAdjective() + " team. " +
                "The End.";

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
        SetAdjective("");
        SetName1("");
        SetName2("");
        SetNoun("");
        ClearInputFields();

        storyBox.SetActive(false);
        inputBoxes.SetActive(true);
    }
}
