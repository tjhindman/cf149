namespace StreamingContentRepository;
// ! REPOSITORY = class used for defining functionality for project
public class Repository
{
    // "protected" only allows for the property to be used by instances of the class or derived classes
    protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    // create
    public bool AddContentToDirectory(StreamingContent content) {
        int prevCount = _contentDirectory.Count;

        _contentDirectory.Add(content);

        return prevCount < _contentDirectory.Count ? true : false;
    }

    // read
    public List<StreamingContent> GetAllContent() {
        return _contentDirectory;
    }

    // read one
    public StreamingContent GetContentByTitle(string title) {
        return _contentDirectory.Find(content => content.Title.ToLower() == title.ToLower());
    }

    // update
    public bool UpdateContent(string originalTitle, StreamingContent newContent) {
        StreamingContent oldContent = GetContentByTitle(originalTitle);

        if(oldContent != null) {
            oldContent.Title = newContent.Title != null ? newContent.Title : oldContent.Title;

            oldContent.Description = newContent.Description != null ? newContent.Description : oldContent.Description;

            oldContent.StarRating = newContent.StarRating != 0 ? newContent.StarRating : oldContent.StarRating;

            // MaturityRating is "enum" type. default for "enum" is 0 index of enum, which would be "MaturityRating.G" in this case
            oldContent.MaturityRating = newContent.MaturityRating != MaturityRating.G ? newContent.MaturityRating : oldContent.MaturityRating;

            // 0 index of GenreType is "GenreType.SciFi" in this case which is the reason for this comparison
            oldContent.TypeOfGenre = newContent.TypeOfGenre != GenreType.SciFi ? newContent.TypeOfGenre : oldContent.TypeOfGenre;

            return true;
        } else {
            return false;
        }
    }

    // delete
    public bool DeleteContent(string title) {
        StreamingContent contentToDelete = GetContentByTitle(title);

        // .Remove() for List<T> type is expecting T to be passed in as the argument
        bool deleteResult = _contentDirectory.Remove(contentToDelete);

        return deleteResult;
    }
}