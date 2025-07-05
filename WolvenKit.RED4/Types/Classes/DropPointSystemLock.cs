using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropPointSystemLock : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lockReason")] 
		public CName LockReason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public DropPointSystemLock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
