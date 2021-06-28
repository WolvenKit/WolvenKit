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
			get => GetProperty(ref _conversations);
			set => SetProperty(ref _conversations, value);
		}

		public audioConversationMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
