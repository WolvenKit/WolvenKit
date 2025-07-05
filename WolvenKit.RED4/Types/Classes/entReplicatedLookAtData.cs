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
			CreationNetTime = new netTime { MilliSecs = long.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
