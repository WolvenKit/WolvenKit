using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetTimeDilation : redEvent
	{
		[Ordinal(0)] 
		[RED("easeOut")] 
		public CName EaseOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
