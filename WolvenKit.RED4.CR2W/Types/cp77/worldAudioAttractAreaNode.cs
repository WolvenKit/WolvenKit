using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAudioAttractAreaNode : worldTriggerAreaNode
	{
		private NodeRef _interestingConversationsNodeRef;
		private CArray<worldAudioAttractAreaNodeSettings> _audioAttractSoundSettings;

		[Ordinal(7)] 
		[RED("interestingConversationsNodeRef")] 
		public NodeRef InterestingConversationsNodeRef
		{
			get
			{
				if (_interestingConversationsNodeRef == null)
				{
					_interestingConversationsNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "interestingConversationsNodeRef", cr2w, this);
				}
				return _interestingConversationsNodeRef;
			}
			set
			{
				if (_interestingConversationsNodeRef == value)
				{
					return;
				}
				_interestingConversationsNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("audioAttractSoundSettings")] 
		public CArray<worldAudioAttractAreaNodeSettings> AudioAttractSoundSettings
		{
			get
			{
				if (_audioAttractSoundSettings == null)
				{
					_audioAttractSoundSettings = (CArray<worldAudioAttractAreaNodeSettings>) CR2WTypeManager.Create("array:worldAudioAttractAreaNodeSettings", "audioAttractSoundSettings", cr2w, this);
				}
				return _audioAttractSoundSettings;
			}
			set
			{
				if (_audioAttractSoundSettings == value)
				{
					return;
				}
				_audioAttractSoundSettings = value;
				PropertySet(this);
			}
		}

		public worldAudioAttractAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
