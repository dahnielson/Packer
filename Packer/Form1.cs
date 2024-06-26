using Packer.Properties;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Packer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            redBox.AllowDrop = true; // R
            greenBox.AllowDrop = true; // G
            blueBox.AllowDrop = true; // B
            alphaBox.AllowDrop = true; // A
            packedBox.AllowDrop = false; // RGBA
        }

        private void redBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void redBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files != null && files.Any())
            {
                redBox.BackgroundImage = Resources.checkerboard;
                redBox.Image = new Bitmap(files[0]);
                packChannels();
            }
        }

        private void greenBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void greenBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files != null && files.Any())
            {
                greenBox.BackgroundImage = Resources.checkerboard;
                greenBox.Image = new Bitmap(files[0]);
                packChannels();
            }
        }

        private void blueBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void blueBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files != null && files.Any())
            {
                blueBox.BackgroundImage = Resources.checkerboard;
                blueBox.Image = new Bitmap(files[0]);
                packChannels();
            }
        }

        private void alphaBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void alphaBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files != null && files.Any())
            {
                alphaBox.BackgroundImage = Resources.checkerboard;
                alphaBox.Image = new Bitmap(files[0]);
                packChannels();
            }
        }

        private void packChannels()
        {
            Bitmap redChannel = null;
            Bitmap greenChannel = null;
            Bitmap blueChannel = null;
            Bitmap alphaChannel = null;

            int width = 0;
            int height = 0;

            if (redBox.Image != null)
            {
                if (redBox.Image.Width > width)
                    width = redBox.Image.Width;
                if (redBox.Image.Height > height)
                    height = redBox.Image.Height;
                redChannel = new Bitmap(redBox.Image);
            }

            if (greenBox.Image != null)
            {
                if (greenBox.Image.Width > width)
                    width = greenBox.Image.Width;
                if (greenBox.Image.Height > height)
                    height = greenBox.Image.Height;
                greenChannel = new Bitmap(greenBox.Image);
            }

            if (blueBox.Image != null)
            {
                if (blueBox.Image.Width > width)
                    width = blueBox.Image.Width;
                if (blueBox.Image.Height > height)
                    height = blueBox.Image.Height;
                blueChannel = new Bitmap(blueBox.Image);
            }

            bool greyscale = true;

            if (alphaBox.Image != null)
            {
                if (alphaBox.Image.Width > width)
                    width = alphaBox.Image.Width;
                if (alphaBox.Image.Height > height)
                    height = alphaBox.Image.Height;
                alphaChannel = new Bitmap(alphaBox.Image);

                for (int y = 0; y < alphaChannel.Height; y++) 
                {
                    for (int x = 0; x < alphaChannel.Width; x++) 
                    {
                        Color pixel = alphaChannel.GetPixel(x, y);
                        if (!(pixel.R == pixel.G && pixel.G == pixel.B && pixel.A == 255))
                        {
                            greyscale = false;
                            break;
                        }
                    }
                }
            }

            if (width == 0 || height == 0)
                return;

            Bitmap packed = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int r = 0;
                    int g = 0;
                    int b = 0;
                    int a = 255;

                    if (redChannel != null)
                    {
                        int sampleX = x;
                        int sampleY = y;

                        if (redChannel.Width < width)
                            sampleX = (int)((x / (double)width) * redChannel.Width);
                        if (redChannel.Height < height)
                            sampleY = (int)((y / (double)height) * redChannel.Height);
                        
                        r = redChannel.GetPixel(sampleX, sampleY).R;
                    }

                    if (greenChannel != null)
                    {
                        int sampleX = x;
                        int sampleY = y;

                        if (greenChannel.Width < width)
                            sampleX = (int)((x / (double)width) * greenChannel.Width);
                        if (greenChannel.Height < height)
                            sampleY = (int)((y / (double)height) * greenChannel.Height);

                        g = greenChannel.GetPixel(sampleX, sampleY).G;
                    }

                    if (blueChannel != null)
                    {
                        int sampleX = x;
                        int sampleY = y;

                        if (blueChannel.Width < width)
                            sampleX = (int)((x / (double)width) * blueChannel.Width);
                        if (blueChannel.Height < height)
                            sampleY = (int)((y / (double)height) * blueChannel.Height);

                        b = blueChannel.GetPixel(sampleX, sampleY).B;
                    }

                    if (alphaChannel != null)
                    {
                        int sampleX = x;
                        int sampleY = y;

                        if (alphaChannel.Width < width)
                            sampleX = (int)((x / (double)width) * alphaChannel.Width);
                        if (alphaChannel.Height < height)
                            sampleY = (int)((y / (double)height) * alphaChannel.Height);

                        if (greyscale)
                            a = alphaChannel.GetPixel(sampleX, sampleY).R;
                        else
                            a = alphaChannel.GetPixel(sampleX, sampleY).A;
                    }

                    Color packedColor = Color.FromArgb(a, r, g, b);
                    packed.SetPixel(x, y, packedColor);
                }
            }

            packedBox.Image = packed;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            redBox.Image = null;
            greenBox.Image = null;
            blueBox.Image = null;
            alphaBox.Image = null;
            packedBox.Image = null;

            redBox.BackgroundImage = Resources.red;
            greenBox.BackgroundImage = Resources.green;
            blueBox.BackgroundImage = Resources.blue;
            alphaBox.BackgroundImage = Resources.alpha;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (packedBox.Image == null)
            {
                MessageBox.Show("No channel packed image to save.", "No Image", MessageBoxButtons.OK);
                return;
            }

            saveFileDialog1.Filter = "PNG Image|*.png";
            saveFileDialog1.Title = "Save Image File";
            if (DialogResult.OK == saveFileDialog1.ShowDialog(this) && saveFileDialog1.FileName != "")
                packedBox.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
        }
    }
}