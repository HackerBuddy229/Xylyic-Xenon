using System;
using Xylyic_Xenon.Models;

namespace Xylyic_Xenon.Services{
    public class BackgroundService {



        public BackgroundModel[] backgrounds;

        public BackgroundService(){
            populate();
        }

        private void populate()
        {
            backgrounds = new BackgroundModel[]{
                new BackgroundModel{FileLocation="/img/backgroundStars.jpg", Credit="Erwan Hesry - Unsplash"},
                new BackgroundModel{FileLocation="/img/BackgroundRuins.jpg", Credit="Felix Tchverkin- Unsplash"},
                new BackgroundModel{FileLocation="/img/backgroundBridge.jpg", Credit="Nicolas Häns - Unsplash"},
                new BackgroundModel{FileLocation="BackgroundMountain.jpg", Credit="Jonny James - Unsplash"}
            };
        }


        public BackgroundModel BackgroundSelect(string index){
                if (index == null){
                    var random = new Random();
                    return (backgrounds[random.Next(backgrounds.Length-1)]);

                }
                var background = backgrounds[Convert.ToInt32(index)];
                return background;


        }
    }
}