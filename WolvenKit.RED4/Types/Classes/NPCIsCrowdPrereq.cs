using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCIsCrowdPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCIsCrowdPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
