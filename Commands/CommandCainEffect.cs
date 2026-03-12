using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walterhcain.EffectTester
{
    public class CommandCainEffect : IRocketCommand
    {
        public List<string> Aliases
        {
            get
            {
                return new List<string>()
                {
                    "e"
                };
            }
        }

        public AllowedCaller AllowedCaller
        {
            get
            {
                return AllowedCaller.Player;
            }
        }

        public string Help
        {
            get
            {
                return "Command to test effects in the game";
            }
        }

        public string Name
        {
            get
            {
                return "caineffect";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>()
                {
                    "caineffect"
                };
            }
        }

        public string Syntax
        {
            get
            {
                return "/caineffect <int>";
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (caller is UnturnedPlayer)
            {
                UnturnedPlayer player = (UnturnedPlayer)caller;
                if (command.Length == 1)
                {
                    int result;
                    if (int.TryParse(command[0], out result))
                    {
                        EffectManager.sendEffect((ushort)result, 25, player.Position);
                    }
                }
                else
                {
                    UnturnedChat.Say(player, "Incorrect paramaters");
                }
            }
            else
            {
                Logger.Log("Only players may execute this command!");
            }
        }
    }
}
