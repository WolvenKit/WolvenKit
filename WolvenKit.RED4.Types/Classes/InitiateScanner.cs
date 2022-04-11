using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InitiateScanner : redEvent
	{
		[Ordinal(0)] 
		[RED("trespasserEntryIndex")] 
		public CInt32 TrespasserEntryIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
