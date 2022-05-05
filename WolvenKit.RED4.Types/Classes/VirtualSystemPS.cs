using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VirtualSystemPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("owner")] 
		public CWeakHandle<MasterControllerPS> Owner
		{
			get => GetPropertyValue<CWeakHandle<MasterControllerPS>>();
			set => SetPropertyValue<CWeakHandle<MasterControllerPS>>(value);
		}

		[Ordinal(106)] 
		[RED("slaves")] 
		public CArray<CHandle<gameDeviceComponentPS>> Slaves
		{
			get => GetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>();
			set => SetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>(value);
		}

		[Ordinal(107)] 
		[RED("slavesCached")] 
		public CBool SlavesCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VirtualSystemPS()
		{
			DeviceName = "SYSTEM";
			Slaves = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
