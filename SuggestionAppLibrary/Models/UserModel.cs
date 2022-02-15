namespace SuggestionAppLibrary.Models;

public class UserModel
{
    // mongoDb Side of users
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    // azure Indetifier

    public string ObjectIndentifier { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }

    // a list of suggestions that the user suggested
    public List<BasicSuggestionModel> AuthoredSuggestions { get; set; } = new();

    public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new();

}
