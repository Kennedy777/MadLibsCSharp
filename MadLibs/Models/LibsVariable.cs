namespace MadLibs.Models
{
  public class LibsVariable
  {
    private string _subject;
    public string GetSubject()
    {
      return _subject;
    }
    public void SetSubject(string newSubject)
    {
      _subject = newSubject;
    }

    private string _emotion1;
    public string GetEmotion1()
    {
      return _emotion1;
    }
    public void SetEmotion1(string newEmotion1)
    {
      _emotion1 = newEmotion1;
    }

    private string _emotion2;
    public string GetEmotion2()
    {
      return _emotion2;
    }
    public void SetEmotion2(string newEmotion2)
    {
      _emotion2 = newEmotion2;
    }

    private string _noun;
    public string GetNoun()
    {
      return _noun;
    }
    public void SetNoun(string newNoun)
    {
       _noun = newNoun;
    }

    private string _place;
    public string GetPlace()
    {
      return _place;
    }
    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }

    private string _bodyFunction;
    public string GetBodyFunction()
    {
      return _bodyFunction;
    }
    public void SetBodyFunction(string newBodyFunction)
    {
      _bodyFunction = newBodyFunction;
    }

    private string _clothingItem;
    public string GetClothingItem()
    {
      return _clothingItem;
    }
    public void SetClothingItem(string newClothingItem)
    {
      _clothingItem = newClothingItem;
    }
  }
}
