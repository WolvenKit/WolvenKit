using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateOverheatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
