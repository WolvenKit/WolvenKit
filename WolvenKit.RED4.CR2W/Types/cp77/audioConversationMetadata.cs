using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioConversationMetadata : audioAudioMetadata
	{
		private CArray<audioConversationItemMetadata> _conversations;

		[Ordinal(1)] 
		[RED("conversations")] 
		public CArray<audioConversationItemMetadata> Conversations
		{
			get
			{
				if (_conversations == null)
				{
					_conversations = (CArray<audioConversationItemMetadata>) CR2WTypeManager.Create("array:audioConversationItemMetadata", "conversations", cr2w, this);
				}
				return _conversations;
			}
			set
			{
				if (_conversations == value)
				{
					return;
				}
				_conversations = value;
				PropertySet(this);
			}
		}

		public audioConversationMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
