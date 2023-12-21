using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace DoomedOfTheDeath.Animations
{
    public class Animation
    {
        private List<AnimationFrame> frames;
        private int counter;

        private double frameMovement = 0; // New code

        public AnimationFrame CurrentFrame { get; set; }

        public Animation()
        {
            frames = new List<AnimationFrame>();
        }

        public void AddFrame(AnimationFrame animationFrame)
        {
            frames.Add(animationFrame);
            CurrentFrame = frames[0];
        }

        //private double secondCounter = 0;

        public void Update(GameTime gameTime)
        {
            CurrentFrame = frames[counter];

            // New code
            frameMovement += CurrentFrame.SourceRectangle.Width * gameTime.ElapsedGameTime.TotalSeconds;
            if(frameMovement >= CurrentFrame.SourceRectangle.Width/8)
            {
                counter++;
                frameMovement = 0;
            }
            // New code

            //secondCounter += gameTime.ElapsedGameTime.TotalSeconds;
            //int fps = 6;

            //if(secondCounter >= 1d/fps)
            //{
            //    counter++;
            //    secondCounter = 0;
            //}

            if(counter >= frames.Count)
            {
                counter = 0;
            }
        }

        /*public void GetFramesFromTextureProperties(int width,  int height, int numberOfWidthSprites, int numberOfHeightSprites)
        {
            int widthOfFrame = width / numberOfWidthSprites;
            int heightOfFrame = height / numberOfHeightSprites;

            for (int y = 0; y <= height - heightOfFrame; y += heightOfFrame)
            {
                for (int x = 0; x <= width - widthOfFrame; x += widthOfFrame)
                {
                    frames.Add(new AnimationFrame(new Rectangle(x, y, widthOfFrame, heightOfFrame)));
                }
            }
        }*/
    }
}
