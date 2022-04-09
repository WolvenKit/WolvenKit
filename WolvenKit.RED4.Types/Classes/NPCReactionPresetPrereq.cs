using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCReactionPresetPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("reactionPreset")] 
		public CEnum<gamedataReactionPresetType> ReactionPreset
		{
			get => GetPropertyValue<CEnum<gamedataReactionPresetType>>();
			set => SetPropertyValue<CEnum<gamedataReactionPresetType>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCReactionPresetPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
