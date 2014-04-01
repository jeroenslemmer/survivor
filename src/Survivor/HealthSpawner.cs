﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survivor
{
    public class HealthSpawner
    {
        public void Spawn(Arena arena)
        {
            if (arena.HealthPacks.Count < 10)
            {
                int x, y;

                do
                {
                    x = random.Next(arena.Width);
                    y = random.Next(arena.Height);
                } while (arena.IsOccupied(x, y) || arena.IsCloseToCreature(x, y));

                var healthPack = new HealthPack(x, y);
                arena.HealthPacks.Add(healthPack);
            }
        }

        private Random random = new Random();
    }
}
