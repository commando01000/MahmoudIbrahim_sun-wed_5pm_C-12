namespace MahmoudIbrahim_sun_wed_5pm_C_12
{
    public delegate string GetTitleDelegate(Book book);
    public delegate decimal GetPriceDelegate(Book book);
    public delegate string GetISBNDelegate(Book book);
    public delegate DateTime GetPublicationDateDelegate(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question_1 Dictionary

            // Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // dictionary.Add(0, "Leinda");
            // Console.WriteLine(dictionary.Count);
            // bool isRepeated = false;
            // string unRepeatedLetters = "";

            //for (int i = 0; i < dictionary.Count; i++)
            //{
            //    // loop on the value of the dictionary
            //    for (int j = 0; j < dictionary.Values.Count; j++)
            //    {
            //        string word = dictionary.Values.ElementAt(j);  // Supraa

            //        for (int k = 0; k < word.Length; k++)
            //        {
            //            for (int h = k + 1; h < word.Length; h++)
            //            {
            //                if (word[k] == word[h])
            //                {
            //                    isRepeated = true;
            //                    break;
            //                }
            //            }
            //            if (!isRepeated)
            //            {
            //                unRepeatedLetters = word[k].ToString();
            //                Console.WriteLine(unRepeatedLetters + $"and its index is {k}");
            //                isRepeated = false;
            //                break; // to get only the first un repeated letter
            //            }
            //        }
            //    }
            //}

            #endregion

            #region Question_2 List

            GetTitleDelegate titleDelegate = BookFunctions.GetTitle;
            GetPriceDelegate priceDelegate = BookFunctions.GetPrice;
            GetISBNDelegate isbnDelegate = BookFunctions.GetISBN;
            GetPublicationDateDelegate publicationDateDelegate = BookFunctions.GetPublicationDate;

            // anonymous function

            isbnDelegate = delegate (Book book)
            {
                return book.ISBN;
            };

            // lambda expression
            publicationDateDelegate = (Book book) => book.PublicationDate;

            #endregion
        }
    }
}
