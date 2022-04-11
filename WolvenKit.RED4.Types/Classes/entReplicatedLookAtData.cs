using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedLookAtData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("creationNetTime")] 
		public netTime CreationNetTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public entReplicatedLookAtData()
		{
			CreationNetTime = new() { MilliSecs = 18446744073709551615 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
