using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkLinkQuickhackEvent : redEvent
	{
		private entEntityID _netrunnerID;
		private entEntityID _proxyID;
		private entEntityID _targetID;
		private entEntityID _from;
		private entEntityID _to;

		[Ordinal(0)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get => GetProperty(ref _netrunnerID);
			set => SetProperty(ref _netrunnerID, value);
		}

		[Ordinal(1)] 
		[RED("proxyID")] 
		public entEntityID ProxyID
		{
			get => GetProperty(ref _proxyID);
			set => SetProperty(ref _proxyID, value);
		}

		[Ordinal(2)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(3)] 
		[RED("from")] 
		public entEntityID From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(4)] 
		[RED("to")] 
		public entEntityID To
		{
			get => GetProperty(ref _to);
			set => SetProperty(ref _to, value);
		}
	}
}
