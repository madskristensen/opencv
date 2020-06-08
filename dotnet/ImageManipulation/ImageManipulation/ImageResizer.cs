using SixLabors.ImageSharp;

namespace ImageManipulation
{
    public class ImageResizer
    {
        public bool TryResize(string filePath, int width, int height)
        {
            try
            {
                using (Image image = Image.Load(filePath))
                {
                    return true;
                }
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
