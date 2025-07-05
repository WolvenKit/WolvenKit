using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HighlightInstance : ModuleInstance
	{
		[Ordinal(6)] 
		[RED("context")] 
		public CEnum<HighlightContext> Context
		{
			get => GetPropertyValue<CEnum<HighlightContext>>();
			set => SetPropertyValue<CEnum<HighlightContext>>(value);
		}

		[Ordinal(7)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HighlightInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
