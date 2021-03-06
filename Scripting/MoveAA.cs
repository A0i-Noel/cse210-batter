using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;
using System;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class MoveActorsAction : Action
    {
         public MoveActorsAction()
        {
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor actor in group)
                {
                    MoveActor(actor);

                }
            }
        }
        
        private void MoveActor(Actor actor)
        {
            int x = actor.GetX();
            int y = actor.GetY();

            int dx = actor.GetVelocity().GetX();
            int dy = actor.GetVelocity().GetY();

            int newX = (x + dx);
            int newY = (y + dy); 

            actor.SetPosition(new Point(newX, newY));
        }

    }
}