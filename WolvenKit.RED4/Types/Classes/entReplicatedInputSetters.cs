using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedInputSetters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("serverReplicatedTime")] 
		public netTime ServerReplicatedTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public entReplicatedInputSetters()
		{
			ServerReplicatedTime = new netTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
