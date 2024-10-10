namespace DevOpsDemo.Models
{
    public partial class PostViewModel
    {
        public int PostId { get; set; }
        public string? Title { get; set; }  // Nullable
        public string? Description { get; set; }  // Nullable
        public string? Author { get; set; }  // Nullable
    }
}
