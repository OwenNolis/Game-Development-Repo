using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace DoomedOfTheDeath.Animations
{
    public class AnimationFrame
    {
        public Rectangle SourceRectangle { get; set; }

        // Overloaded constructor
        public AnimationFrame(Rectangle rectangle)
        {
            SourceRectangle = rectangle;
        }
    }
}
