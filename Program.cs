namespace GA_CustomList
{
    internal class Program
    {
        // Jonathan Reed 1/9/2024

        
        static void Main(string[] args)
        {
            CustomList<string> customList = new CustomList<string>();
            int n = customList.Count;
            customList.Add("a");
            customList.AddAtIndex("b", 1);
            customList.Remove("b");
            customList.GetItem(0);
            customList.DisplayInformation();
            
        }
    }
}
