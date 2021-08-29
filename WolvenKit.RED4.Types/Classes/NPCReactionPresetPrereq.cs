using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCReactionPresetPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataReactionPresetType> _reactionPreset;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("reactionPreset")] 
		public CEnum<gamedataReactionPresetType> ReactionPreset
		{
			get => GetProperty(ref _reactionPreset);
			set => SetProperty(ref _reactionPreset, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}
	}
}
