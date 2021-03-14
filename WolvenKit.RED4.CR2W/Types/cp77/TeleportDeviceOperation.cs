using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TeleportDeviceOperation : DeviceOperationBase
	{
		private STeleportOperationData _teleport;

		[Ordinal(5)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get
			{
				if (_teleport == null)
				{
					_teleport = (STeleportOperationData) CR2WTypeManager.Create("STeleportOperationData", "teleport", cr2w, this);
				}
				return _teleport;
			}
			set
			{
				if (_teleport == value)
				{
					return;
				}
				_teleport = value;
				PropertySet(this);
			}
		}

		public TeleportDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
