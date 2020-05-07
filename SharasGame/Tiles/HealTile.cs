using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharasGame
{
    public class HealTile : GameTile
    {

        public HealTile()
        {
            symbol = 'H';
        }
        public override void OnStep(Game game)
        {
            game.player.HP = game.player.maxHP;
        }
    }
}
