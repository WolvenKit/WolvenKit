using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleHealthStatPoolListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<vehicleBaseObject> _owner;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<vehicleBaseObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "owner", cr2w, this);
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

		public VehicleHealthStatPoolListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
