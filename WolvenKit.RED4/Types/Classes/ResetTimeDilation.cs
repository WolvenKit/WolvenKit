using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResetTimeDilation : redEvent
	{
		[Ordinal(0)] 
		[RED("easeOut")] 
		public CName EaseOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("global")] 
		public CBool Global
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ResetTimeDilation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
