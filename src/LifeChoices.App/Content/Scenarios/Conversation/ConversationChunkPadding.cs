using System;

using LifeChoices.App.Domain.Conversational;

namespace LifeChoices.App.Content.Scenarios.Conversation
{
    public class ConversationChunkPaddingTop : ConversationChunk
    {
        public ConversationChunkPaddingTop(DateTime sentTime, Participant author, string text)
            : base(sentTime, author, text)
        {
        }

        public ConversationChunkPaddingTop()
            : this(DateTime.MaxValue, null, null)
        {
        }
    }

    public class ConversationChunkPaddingBottom : ConversationChunk
    {
        public ConversationChunkPaddingBottom(DateTime sentTime, Participant author, string text)
            : base(sentTime, author, text)
        {
        }

        public ConversationChunkPaddingBottom()
            : this(DateTime.MaxValue, null, null)
        {
        }
    }
}
