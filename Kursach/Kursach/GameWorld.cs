using System.Collections.Generic;
using System.Linq;

using Kursach.GameObjects;

namespace Kursach
{
    class GameWorld
    {
        readonly List<GameObject> gameObjects;


        public List<Cactus> ObjectsCacti { get; }
        public Ground ObjectGround { get; }
        public Dinosaur ObjectDinosaur { get; }
        public CactiCounter ObjectCactiCounter { get;}


        public bool IsPlaying => ObjectDinosaur.IsAlive;


        public GameWorld(Ground ground, IEnumerable<Cactus> cacti, Dinosaur dinosaur, CactiCounter cactiCounter)
        {
            ObjectsCacti = cacti.ToList();
            ObjectGround = ground;
            ObjectDinosaur = dinosaur;
            ObjectCactiCounter = cactiCounter;

            gameObjects = new();
            gameObjects.AddRange(cacti);
            gameObjects.Add(ground);
            gameObjects.Add(dinosaur);
            gameObjects.Add(cactiCounter);
        }


        public void Update() => gameObjects
            .ForEach(obj => obj.Update(this));

        public DrawPacket GetDrawPacket() => new(gameObjects);
    }
}
