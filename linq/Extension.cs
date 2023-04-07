namespace linq
{
    public static class Extension
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        {
            List<T> filteredList = new();
            filteredList.AddRange(from T record in records
                                  where func(record)
                                  select record);
            return filteredList;
        }
    }
}