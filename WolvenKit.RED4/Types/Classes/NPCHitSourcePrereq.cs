using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCHitSourcePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("hitSource")] 
		public CEnum<EAIHitSource> HitSource
		{
			get => GetPropertyValue<CEnum<EAIHitSource>>();
			set => SetPropertyValue<CEnum<EAIHitSource>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCHitSourcePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
