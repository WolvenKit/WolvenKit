using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnProgressBarAnimFinish : redEvent
	{
		[Ordinal(0)] 
		[RED("FullbarSize")] 
		public CFloat FullbarSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("IsNegative")] 
		public CBool IsNegative
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OnProgressBarAnimFinish()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
