using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkLinkQuickhackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("proxyID")] 
		public entEntityID ProxyID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(3)] 
		[RED("from")] 
		public entEntityID From
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("to")] 
		public entEntityID To
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public NetworkLinkQuickhackEvent()
		{
			NetrunnerID = new entEntityID();
			ProxyID = new entEntityID();
			TargetID = new entEntityID();
			From = new entEntityID();
			To = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
