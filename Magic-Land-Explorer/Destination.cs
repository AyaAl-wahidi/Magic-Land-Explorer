namespace Magic_Land_Explorer
{
    public class Destination
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }

        public int GetDuration() // We have the duration like this with string ==> "duration": "82 minutes"
        {
            if (string.IsNullOrEmpty(Duration))
            {
                return 0;
            }
            if (int.TryParse(Duration.Split(' ')[0], out int result))
            {
                return result;
            }
            return 0;
        }
    }
}