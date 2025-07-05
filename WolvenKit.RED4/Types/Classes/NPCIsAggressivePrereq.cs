using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCIsAggressivePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCIsAggressivePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
