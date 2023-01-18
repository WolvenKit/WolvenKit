using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSaveLock : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("reason")] 
		public CEnum<gameSaveLockReason> Reason
		{
			get => GetPropertyValue<CEnum<gameSaveLockReason>>();
			set => SetPropertyValue<CEnum<gameSaveLockReason>>(value);
		}

		public gameSaveLock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
