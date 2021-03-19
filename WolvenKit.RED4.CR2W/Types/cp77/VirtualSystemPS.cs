using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualSystemPS : MasterControllerPS
	{
		private wCHandle<MasterControllerPS> _owner;
		private CArray<CHandle<gameDeviceComponentPS>> _slaves;
		private CBool _slavesCached;

		[Ordinal(104)] 
		[RED("owner")] 
		public wCHandle<MasterControllerPS> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(105)] 
		[RED("slaves")] 
		public CArray<CHandle<gameDeviceComponentPS>> Slaves
		{
			get => GetProperty(ref _slaves);
			set => SetProperty(ref _slaves, value);
		}

		[Ordinal(106)] 
		[RED("slavesCached")] 
		public CBool SlavesCached
		{
			get => GetProperty(ref _slavesCached);
			set => SetProperty(ref _slavesCached, value);
		}

		public VirtualSystemPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
