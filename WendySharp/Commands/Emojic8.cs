﻿using System;
using System.Collections.Generic;

namespace WendySharp
{
    class Emojic8 : Command
    {
        private readonly List<string> Emojis = new List<string>
        {
            "🙅",
            "🙆",
            "🙇",
            "🙋",
            "🙌",
            "🙍",
            "🙎",
            "🙏",
            "✂",
            "✈",
            "✉",
            "✊",
            "✋",
            "✌",
            "✏",
            "❄",
            "❤",
            "🚀",
            "🚃",
            "🚄",
            "🚅",
            "🚇",
            "🚉",
            "🚌",
            "🚏",
            "🚑",
            "🚒",
            "🚓",
            "🚕",
            "🚗",
            "🚙",
            "🚚",
            "🚢",
            "🚤",
            "🚥",
            "🚧",
            "🚨",
            "🚩",
            "🚪",
            "🚫",
            "🚬",
            "🚲",
            "🚶",
            "🚽",
            "🛀",
            "⌚",
            "⌛",
            "⏰",
            "⏳",
            "☁",
            "☎",
            "☔",
            "☕",
            "♨",
            "♻",
            "♿",
            "⚓",
            "⚡",
            "⚽",
            "⚾",
            "⛄",
            "⛅",
            "⛪",
            "⛲",
            "⛳",
            "⛵",
            "⛺",
            "⭐",
            "⛽",
            "🃏",
            "🌀",
            "🌁",
            "🌂",
            "🌃",
            "🌄",
            "🌅",
            "🌆",
            "🌇",
            "🌈",
            "🌉",
            "🌊",
            "🌋",
            "🌏",
            "🌙",
            "🌛",
            "🌟",
            "🌠",
            "🌰",
            "🌱",
            "🌴",
            "🌵",
            "🌷",
            "🌸",
            "🌹",
            "🌺",
            "🌻",
            "🌼",
            "🌽",
            "🌾",
            "🌿",
            "🍀",
            "🍁",
            "🍂",
            "🍃",
            "🍄",
            "🍅",
            "🍆",
            "🍇",
            "🍈",
            "🍉",
            "🍊",
            "🍌",
            "🍍",
            "🍎",
            "🍏",
            "🍑",
            "🍒",
            "🍓",
            "🍔",
            "🍕",
            "🍖",
            "🍗",
            "🍘",
            "🍙",
            "🍚",
            "🍛",
            "🍜",
            "🍝",
            "🍞",
            "🍟",
            "🍠",
            "🍡",
            "🍢",
            "🍣",
            "🍤",
            "🍥",
            "🍦",
            "🍧",
            "🍨",
            "🍩",
            "🍪",
            "🍫",
            "🍬",
            "🍭",
            "🍮",
            "🍯",
            "🍰",
            "🍱",
            "🍲",
            "🍳",
            "🍴",
            "🍵",
            "🍶",
            "🍷",
            "🍸",
            "🍹",
            "🍺",
            "🍻",
            "🎀",
            "🎁",
            "🎂",
            "🎃",
            "🎄",
            "🎅",
            "🎆",
            "🎇",
            "🎈",
            "🎉",
            "🎊",
            "🎋",
            "🎌",
            "🎍",
            "🎎",
            "🎏",
            "🎐",
            "🎑",
            "🎒",
            "🎓",
            "🎠",
            "🎡",
            "🎢",
            "🎣",
            "🎤",
            "🎥",
            "🎦",
            "🎧",
            "🎨",
            "🎩",
            "🎪",
            "🎫",
            "🎬",
            "🎭",
            "🎮",
            "🎯",
            "🎰",
            "🎱",
            "🎲",
            "🎳",
            "🎴",
            "🎵",
            "🎶",
            "🎷",
            "🎸",
            "🎹",
            "🎺",
            "🎻",
            "🎽",
            "🎾",
            "🎿",
            "🏀",
            "🏁",
            "🏂",
            "🏃",
            "🏄",
            "🏆",
            "🏈",
            "🏊",
            "🏠",
            "🏡",
            "🏢",
            "🏣",
            "🏥",
            "🏦",
            "🏧",
            "🏨",
            "🏩",
            "🏪",
            "🏫",
            "🏬",
            "🏭",
            "🏮",
            "🏯",
            "🏰",
            "🐌",
            "🐍",
            "🐎",
            "🐑",
            "🐒",
            "🐔",
            "🐗",
            "🐘",
            "🐙",
            "🐚",
            "🐛",
            "🐜",
            "🐝",
            "🐞",
            "🐟",
            "🐠",
            "🐡",
            "🐢",
            "🐣",
            "🐤",
            "🐥",
            "🐦",
            "🐧",
            "🐨",
            "🐩",
            "🐫",
            "🐬",
            "🐭",
            "🐮",
            "🐯",
            "🐰",
            "🐱",
            "🐲",
            "🐳",
            "🐴",
            "🐵",
            "🐶",
            "🐷",
            "🐸",
            "🐹",
            "🐺",
            "🐻",
            "🐼",
            "🐽",
            "🐾",
            "👀",
            "👂",
            "👃",
            "👄",
            "👅",
            "👆",
            "👇",
            "👈",
            "👉",
            "👊",
            "👋",
            "👌",
            "👍",
            "👎",
            "👏",
            "👐",
            "👑",
            "👒",
            "👓",
            "👔",
            "👕",
            "👖",
            "👗",
            "👘",
            "👙",
            "👚",
            "👛",
            "👜",
            "👝",
            "👞",
            "👟",
            "👠",
            "👡",
            "👢",
            "👣",
            "👤",
            "👦",
            "👧",
            "👨",
            "👩",
            "👪",
            "👫",
            "👮",
            "👯",
            "👰",
            "👱",
            "👴",
            "👶",
            "👷",
            "👸",
            "👹",
            "👺",
            "👻",
            "👼",
            "👽",
            "👾",
            "👿",
            "💀",
            "💁",
            "💂",
            "💃",
            "💄",
            "💅",
            "💆",
            "💇",
            "💈",
            "💉",
            "💊",
            "💋",
            "💌",
            "💍",
            "💎",
            "💏",
            "💐",
            "💑",
            "💒",
            "💓",
            "💔",
            "💕",
            "💖",
            "💗",
            "💘",
            "💙",
            "💚",
            "💛",
            "💜",
            "💝",
            "💞",
            "💟",
            "💠",
            "💡",
            "💢",
            "💣",
            "💤",
            "💥",
            "💦",
            "💧",
            "💨",
            "💩",
            "💪",
            "💫",
            "💬",
            "💮",
            "💯",
            "💰",
            "💲",
            "💳",
            "💵",
            "💸",
            "💺",
            "💻",
            "💼",
            "💽",
            "💾",
            "💿",
            "📀",
            "📃",
            "📅",
            "📆",
            "📈",
            "📉",
            "📌",
            "📍",
            "📎",
            "📓",
            "📔",
            "📕",
            "📖",
            "📞",
            "📟",
            "📠",
            "📡",
            "📣",
            "📦",
            "📧",
            "📫",
            "📰",
            "📱",
            "📷",
            "📹",
            "📺",
            "📻",
            "📼",
            "🔊",
            "🔋",
            "🔌",
            "🔎",
            "🔐",
            "🔑",
            "🔒",
            "🔓",
            "🔔",
            "🔜",
            "🔥",
            "🔦",
            "🔧",
            "🔨",
            "🔩",
            "🔪",
            "🔫",
            "🔮",
            "🗻",
            "🗼",
            "🗽",
            "🗾",
            "🗿",
            "😴",
            "🚁",
            "🚂",
            "🚆",
            "🚈",
            "🚊",
            "🚍",
            "🚎",
            "🚐",
            "🚔",
            "🚖",
            "🚘",
            "🚛",
            "🚜",
            "🚝",
            "🚞",
            "🚟",
            "🚠",
            "🚡",
            "🚣",
            "🚦",
            "🚮",
            "🚵",
            "🚿",
            "🛁",
            "🌍",
            "🌎",
            "🌜",
            "🌝",
            "🌞",
            "🌲",
            "🌳",
            "🍋",
            "🍐",
            "🍼",
            "🏇",
            "🏉",
            "🏤",
            "🐀",
            "🐁",
            "🐂",
            "🐃",
            "🐄",
            "🐅",
            "🐆",
            "🐇",
            "🐈",
            "🐉",
            "🐊",
            "🐋",
            "🐏",
            "🐐",
            "🐓",
            "🐕",
            "🐖",
            "🐪",
            "👬",
            "👭",
            "📬",
            "📭",
            "📯",
            "🔬",
            "🔭"
        };

        public Emojic8()
        {
            Match = new List<string>
            {
                "8ball",
                "emojic8"
            };
            Usage = "<question>";
            ArgumentMatch = "(?<text>.+)$";
            HelpText = "Emojic Eight Ball. Inspired by https://xkcd.com/1525/";
        }

        public override void OnCommand(CommandArguments command)
        {
            var random = new Random(command.Arguments.Groups["text"].Value.Trim().GetHashCode());
            var randomStrLength = random.Next(1, 3); // Math.floor(min + Math.random() * (max - min))
            var answer = "" + Color.NORMAL;

            for (var i = 0; i < randomStrLength; i++)
            {
                var randomIndex = random.Next(Emojis.Count);

                answer += Emojis[randomIndex];
            }

            command.Reply(answer);
        }
    }
}
