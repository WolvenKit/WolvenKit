using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUnassignAll_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CBool _isInstant;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get
			{
				if (_isInstant == null)
				{
					_isInstant = (CBool) CR2WTypeManager.Create("Bool", "isInstant", cr2w, this);
				}
				return _isInstant;
			}
			set
			{
				if (_isInstant == value)
				{
					return;
				}
				_isInstant = value;
				PropertySet(this);
			}
		}

		public questUnassignAll_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
