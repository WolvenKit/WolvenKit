using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BinkVideoEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("path")] 
		public redResourceReferenceScriptToken Path
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(1)] 
		[RED("startingTime")] 
		public CFloat StartingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("shouldPlay")] 
		public CBool ShouldPlay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BinkVideoEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
