using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SNetworkLinkData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("beam")] 
		public CHandle<gameFxInstance> Beam
		{
			get => GetPropertyValue<CHandle<gameFxInstance>>();
			set => SetPropertyValue<CHandle<gameFxInstance>>(value);
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(2)] 
		[RED("slaveID")] 
		public entEntityID SlaveID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(3)] 
		[RED("masterID")] 
		public entEntityID MasterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("slavePos")] 
		public Vector4 SlavePos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("masterPos")] 
		public Vector4 MasterPos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("drawLink")] 
		public CBool DrawLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("isPing")] 
		public CBool IsPing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isNetrunner")] 
		public CBool IsNetrunner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("linkType")] 
		public CEnum<ELinkType> LinkType
		{
			get => GetPropertyValue<CEnum<ELinkType>>();
			set => SetPropertyValue<CEnum<ELinkType>>(value);
		}

		[Ordinal(15)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetPropertyValue<CEnum<EPriority>>();
			set => SetPropertyValue<CEnum<EPriority>>(value);
		}

		[Ordinal(16)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(18)] 
		[RED("weakLink")] 
		public CBool WeakLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SNetworkLinkData()
		{
			FxResource = new();
			SlaveID = new();
			MasterID = new();
			SlavePos = new();
			MasterPos = new();
			DrawLink = true;
			RevealMaster = true;
			RevealSlave = true;
			Lifetime = -1.000000F;
			DelayID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
