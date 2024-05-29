using System;
using System.Drawing;
using System.Windows.Forms;

class SinusoidApp : Form
{
    const int width = 800;
    const int height = 400;
    const int margin = 20;

    public SinusoidApp()
    {
        // Ustawienia okna aplikacji
        Text = "Sinusoida";
        ClientSize = new Size(width, height);
        BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        Pen pen = new Pen(Color.Blue, 2);

        // Rysowanie osi X i Y
        g.DrawLine(Pens.Black, margin, height / 2, width - margin, height / 2); // Oś X
        g.DrawLine(Pens.Black, margin, margin, margin, height - margin); // Oś Y

        // Rysowanie sinusoidy
        double scale = 20; // Skala, aby zmieścić sinusoidę na ekranie
        for (int x = margin; x < width - margin; x++)
        {
            double t = (x - margin) / scale; // Wartość argumentu (czasu)
            double y = Math.Sin(t); // Wartość sinusoidy dla danego czasu

            // Przekształcenie wartości sinusoidy na współrzędną y na ekranie
            int screenY = height / 2 - (int)(y * scale);

            // Rysowanie sinusoidy piksel po pikselu
            g.FillRectangle(Brushes.Blue, x, screenY, 1, 1);
        }
    }

    static void Main()
    {
        Application.Run(new SinusoidApp());
    }
}
