using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace c_sharp_snake_game
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static    ImageSource Body =         LoadImage("Body")             ;
        public readonly static    ImageSource Head =         LoadImage("Head")             ;
        public readonly static    ImageSource Food =         LoadImage("Food")             ;
        public readonly static    ImageSource DeadHead =     LoadImage("DeadHead")         ;

        private static ImageSource LoadImage(string filename)
        {
            return new BitmapImage(new Uri($"Assets/{filename}"), UriKind.Relative);
        }
    }
}
