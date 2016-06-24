using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLGSDK
{
    public class DraggableForm: Form
    {

        public DraggableForm()
        {
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
        }

        Point FirstPoint { get; set; }
        EnumDragDropState DragState { get; set; }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            FirstPoint = e.Location;
            DragState = EnumDragDropState.Dragging;
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            DragState = EnumDragDropState.Dropped;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (DragState == EnumDragDropState.Dragging)
            {
                // Get the difference between the two points
                int xDiff = FirstPoint.X - e.Location.X;
                int yDiff = FirstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
    }
}
