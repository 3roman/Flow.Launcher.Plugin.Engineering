namespace Flow.Launcher.Plugin.Engineering.XNoteFinder
{
    internal class ImageHelper
    {
        public static void BytesToImage(byte[] bytes, string imagePath)
        {
            FileStream fs = new FileStream(imagePath, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(bytes);
            bw.Close();
            fs.Close();
        }
    }
}
