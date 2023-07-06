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
			SourceID = new entEntityID();
			LinkData = new SNetworkLinkData { FxResource = new gameFxResource(), SlaveID = new entEntityID(), MasterID = new entEntityID(), SlavePos = new Vector4(), MasterPos = new Vector4(), DrawLink = true, RevealMaster = true, RevealSlave = true, Lifetime = -1.000000F, DelayID = new gameDelayID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
