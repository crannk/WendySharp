﻿using System;
using System.Collections.Generic;

namespace WendySharp
{
    class TopicReplace : Command
    {
        public TopicReplace()
        {
            Match = new List<string>
            {
                "topicreplace",
                "treplace",
            };
            Usage = "<pos> <text>";
            ArgumentMatch = "(?<pos>[0-9]+) (?<text>.+)$";
            HelpText = "Replaces the given section with the given text. Remember indexes start at 0.";
            Permission = "irc.op.topic";
        }

        public override void OnCommand(CommandArguments command)
        {
            var channel = Bootstrap.Client.ChannelList.GetChannel(command.Event.Recipient);

            var topic = channel.Topic.Split(new [] { " | " }, StringSplitOptions.None);
            
            if (topic.Length < 2)
            {
                command.Reply("Not enough parts in the topic to replace anything.");

                return;
            }

            if (!uint.TryParse(command.Arguments.Groups["pos"].Value, out var pos) || pos >= topic.Length)
            {
                command.Reply("There are only {0} topic parts. Remember indexes start at 0.", topic.Length);

                return;
            }

            topic[pos] = command.Arguments.Groups["text"].Value.Trim();

            var newTopic = string.Join(" | ", topic).Trim();

            if (newTopic == channel.Topic)
            {
                return;
            }

            Bootstrap.Client.Client.ChangeChannelTopic(command.Event.Recipient, newTopic);
        }
    }
}
