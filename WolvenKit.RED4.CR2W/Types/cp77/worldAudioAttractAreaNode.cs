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
			get => GetProperty(ref _interestingConversationsNodeRef);
			set => SetProperty(ref _interestingConversationsNodeRef, value);
		}

		[Ordinal(8)] 
		[RED("audioAttractSoundSettings")] 
		public CArray<worldAudioAttractAreaNodeSettings> AudioAttractSoundSettings
		{
			get => GetProperty(ref _audioAttractSoundSettings);
			set => SetProperty(ref _audioAttractSoundSettings, value);
		}

		public worldAudioAttractAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
