using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointSystemLock : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lockReason")] 
		public CName LockReason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
