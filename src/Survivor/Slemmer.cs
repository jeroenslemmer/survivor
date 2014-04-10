using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Survivor.Core;

namespace Survivor
{
  public class Slemmer : Creature
  {
    public override void Update(IReadOnlyList<Creature> creatures, IReadOnlyList<Item> items)
    {
      Scout();
    }

    int scoutDirection = 1;
    private void Scout()
    {
      switchScoutDirectionAtBorder();
      moveInScoutDirection();
    }

    private void switchScoutDirectionAtBorder()
    {
      switch (scoutDirection)
      {
        case 1:
          if (X > ArenaWidth - 2)
          {
            scoutDirection = 0;
          }
          break;
        case 2:
          if (Y > ArenaHeight - 2)
          {
            scoutDirection = 1;
          }
          break;
        case 3:
          if (X < 1)
          {
            scoutDirection = 2;
          }
          break;
        case 0:
          if (Y < 1)
          {
            scoutDirection = 3;
          }
          break;
      }
    }

    private void moveInScoutDirection()
    {
      switch (scoutDirection)
      {
        case 0:
          MoveUp();
          break;
        case 1:
          MoveRight();
          break;
        case 2:
          MoveDown();
          break;
        case 3:
          MoveLeft();
          break;
      }
    }

  }
}
