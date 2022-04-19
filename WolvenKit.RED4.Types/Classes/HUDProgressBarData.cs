using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDProgressBarData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HUDProgressBarData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
