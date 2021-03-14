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
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<MasterControllerPS>) CR2WTypeManager.Create("whandle:MasterControllerPS", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("slaves")] 
		public CArray<CHandle<gameDeviceComponentPS>> Slaves
		{
			get
			{
				if (_slaves == null)
				{
					_slaves = (CArray<CHandle<gameDeviceComponentPS>>) CR2WTypeManager.Create("array:handle:gameDeviceComponentPS", "slaves", cr2w, this);
				}
				return _slaves;
			}
			set
			{
				if (_slaves == value)
				{
					return;
				}
				_slaves = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("slavesCached")] 
		public CBool SlavesCached
		{
			get
			{
				if (_slavesCached == null)
				{
					_slavesCached = (CBool) CR2WTypeManager.Create("Bool", "slavesCached", cr2w, this);
				}
				return _slavesCached;
			}
			set
			{
				if (_slavesCached == value)
				{
					return;
				}
				_slavesCached = value;
				PropertySet(this);
			}
		}

		public VirtualSystemPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
