using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealDeviceRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("linkData")] 
		public SNetworkLinkData LinkData
		{
			get => GetPropertyValue<SNetworkLinkData>();
			set => SetPropertyValue<SNetworkLinkData>(value);
		}

		public RevealDeviceRequest()
		{
			SourceID = new();
			LinkData = new() { FxResource = new(), SlaveID = new(), MasterID = new(), SlavePos = new(), MasterPos = new(), DrawLink = true, RevealMaster = true, RevealSlave = true, Lifetime = -1.000000F, DelayID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
