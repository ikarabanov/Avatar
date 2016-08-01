using Avatars.StateManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatars.GameStates
{
    public class BaseGameState : GameState
    {
        #region
        protected static Random random = new Random();
        protected Game1 GameRef;
        #endregion

        #region Constructor Region
        public BaseGameState(Game game) : base(game)
        {
            GameRef = (Game1)game;
        }
        protected override void LoadContent()
        {
            base.LoadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
        #endregion
    }
}
