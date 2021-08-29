using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualSystemPS : MasterControllerPS
	{
		private CWeakHandle<MasterControllerPS> _owner;
		private CArray<CHandle<gameDeviceComponentPS>> _slaves;
		private CBool _slavesCached;

		[Ordinal(105)] 
		[RED("owner")] 
		public CWeakHandle<MasterControllerPS> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(106)] 
		[RED("slaves")] 
		public CArray<CHandle<gameDeviceComponentPS>> Slaves
		{
			get => GetProperty(ref _slaves);
			set => SetProperty(ref _slaves, value);
		}

		[Ordinal(107)] 
		[RED("slavesCached")] 
		public CBool SlavesCached
		{
			get => GetProperty(ref _slavesCached);
			set => SetProperty(ref _slavesCached, value);
		}
	}
}
