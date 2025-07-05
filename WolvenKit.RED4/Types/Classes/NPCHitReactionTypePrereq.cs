using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCHitReactionTypePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get => GetPropertyValue<CEnum<animHitReactionType>>();
			set => SetPropertyValue<CEnum<animHitReactionType>>(value);
		}

		[Ordinal(1)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCHitReactionTypePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
