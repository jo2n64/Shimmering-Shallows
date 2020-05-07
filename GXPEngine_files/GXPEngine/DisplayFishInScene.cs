﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine
{
    class DisplayFishInScene : GameObject
    {
        Fish fish1Scene1;
        Fish fish2Scene1;
        Fish fish3Scene1;
        Fish fish4Scene1;
        Fish fish5Scene1;
        Fish fish1Scene2;
        Fish fish2Scene2;
        Fish fish3Scene2;
        Fish fish4Scene2;
        Fish fish5Scene2;
        public DisplayFishInScene(int sceneNumber,List<Food> foodList,List<Fish> fishListPerScene)
        {
            switch (sceneNumber)
            {
                case 1:
                    loadScene1(foodList, fishListPerScene);
                    break;
                case 2:
                    loadScene2(foodList, fishListPerScene);
                    break;

            }

        }

        void loadScene1(List<Food> foodList, List<Fish> fishListPerScene)
        {
             fish1Scene1=new Fish(foodList, "Fresh water", "European Perch", "It belongs to the genus perch and can be found in most of Europe and Siberia but has also been introduced to Oceania and South Africa. It is typically less than 25 cm long and has a greenish base color with 5 to 9 dark green bars on its body. Their meals mostly consist of worms, insects, and smaller fish.");
             fish2Scene1=new Fish(foodList, "Fresh water", "Northern pike", "Its name translated literally means “water wolf”. This name comes from them eating most fishes smaller than them with them sometimes even eating other northern pikes. They can typically be found in most of North America and Europe. Their average length is between 40 and 55cm and they can be identified by their long body and their bright green color");
             fish3Scene1=new Fish(foodList, "Fresh water", "Walleye", "It is related to the Northern pike which can also be found in this aquarium. It is native to most of the United States of America and Canada. Walleyes are largely olive and gold in color and their unique name comes from the position of their eyes which point outwards as if they are looking at the walls. Their diet mostly consists of smaller fish");
             fish4Scene1=new Fish(foodList, "Fresh water", "Tench", "It is known for being a quiet enduring fish with it is mostly found in muddy and overgrown lakes in Europe and eastern Russia where it can survive even with low oxygen concentration. Its maximum size is at 70cm and it can be recognized by its darker olive-green skin and its almost golden color below.");
             fish5Scene1=new Fish(foodList, "Fresh water", "Sturgeon", "It is quite a rare sight these days as it is considered an almost extinct species. Their unique look has not changed since their earliest fossil record earning it the name of “living fossil”. They can grow up to be between 2 and 3 ½ meters and are hunted for their meat and caviar. The Sturgeons range is from subtropical to subarctic waters in North America and Eurasia.");
            fishListPerScene.Add(fish1Scene1);
            fishListPerScene.Add(fish2Scene1);
            fishListPerScene.Add(fish3Scene1);
            fishListPerScene.Add(fish4Scene1);
            fishListPerScene.Add(fish5Scene1);
        }
        void loadScene2(List<Food> foodList, List<Fish> fishListPerScene)
        {
            fish1Scene2 = new Fish(foodList, "Sea water", "dicks", "yes");
            fish2Scene2 = new Fish(foodList, "Sea water", "dicks", "yes");
            fish3Scene2 = new Fish(foodList, "Sea water", "dicks", "yes");
            fish4Scene2 = new Fish(foodList, "Sea water", "dicks", "yes");
            fish5Scene2 = new Fish(foodList, "Sea water", "dicks", "yes");
            fishListPerScene.Add(fish1Scene2);
            fishListPerScene.Add(fish2Scene2);
            fishListPerScene.Add(fish3Scene2);
            fishListPerScene.Add(fish4Scene2);
            fishListPerScene.Add(fish5Scene2);
        }
    }
}
