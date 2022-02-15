namespace SuggestionAppLibrary.Models;

public class BasicUserModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string DisplayName { get; set; }

    public BasicUserModel() { }

    // if you create an explicit constructor it will overide the implicit one that is why you create the implicite as well
    public BasicUserModel(UserModel user)
    {
        Id = user.Id;
        DisplayName = user.DisplayName;
    }
}
