using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// TODO: OPTIMIZE DIS
[ToolboxItem(true)]
[Description("A minimal solid-type button w/ text")]
[ToolboxBitmap(typeof(Button))]
public class SolidButton : Control
{
    private Color _ButtonColor = Color.FromArgb(48, 48, 48);
    private Color _HoverColor = Color.FromArgb(52, 52, 52);
    private Color _ClickedColor = Color.FromArgb(57, 57, 57);

    public Color ButtonColor
    {
        get => _ButtonColor;
        set
        {
            _ButtonColor = value;
            Invalidate(); // refresh
        }
    }

    public Color HoverColor
    {
        get => _HoverColor;
        set => _HoverColor = value;
    }

    public Color HeldColor
    {
        get => _ClickedColor;
        set => _ClickedColor = value;
    }

    public SolidButton()
    {
        SetStyle(ControlStyles.UserPaint, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        BackColor = ButtonColor;

        MouseEnter += (s, e) => {
            BackColor = HoverColor;
            Cursor = Cursors.Hand;
        };

        MouseLeave += (s, e) => {
            BackColor = ButtonColor;
            Cursor = Cursors.Default;
        };

        MouseDown += (s, e) => {
            BackColor = HeldColor;
            Cursor = Cursors.Hand;
        };

        MouseUp += (s, e) => {
            BackColor = HoverColor;
            Cursor = Cursors.Hand;
        };
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // da background
        using (SolidBrush brush = new SolidBrush(BackColor))
        {
            e.Graphics.FillRectangle(brush, ClientRectangle);
        }

        using (SolidBrush textBrush = new SolidBrush(ForeColor))
        {
            SizeF textSize = e.Graphics.MeasureString(Text, Font);

            PointF textLocation = new PointF(
                (Width - textSize.Width) / 2,
                (Height - textSize.Height) / 2
            );

            e.Graphics.DrawString(Text, Font, textBrush, textLocation);
        }
    }
}