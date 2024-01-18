using System;
using System.Windows.Forms;

namespace ExampleProgram
{
public class ExampleForm : Form
{
    private Button button;

    public ExampleForm()
    {
        Text = "Example Program";
        Size = new System.Drawing.Size(300, 200);

        button = new Button();
        button.Text = "Click me!";
        button.Location = new System.Drawing.Point(100, 50);
        button.Size = new System.Drawing.Size(75, 23);
        button.Click += new EventHandler(button_Click);

        Controls.Add(button);
    }

    void button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello, world!");
    }

    static void Main()
    {
        Application.Run(new ExampleForm());
    }
}
}
