using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameOverrideMissShotOffset : redEvent
	{
		[Ordinal(0)] 
		[RED("overrideRecord")] 
		public CString OverrideRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameOverrideMissShotOffset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
