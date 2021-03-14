using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleBrokenTire_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CBool _val;
		private CUInt32 _tire;

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
		[RED("val")] 
		public CBool Val
		{
			get
			{
				if (_val == null)
				{
					_val = (CBool) CR2WTypeManager.Create("Bool", "val", cr2w, this);
				}
				return _val;
			}
			set
			{
				if (_val == value)
				{
					return;
				}
				_val = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tire")] 
		public CUInt32 Tire
		{
			get
			{
				if (_tire == null)
				{
					_tire = (CUInt32) CR2WTypeManager.Create("Uint32", "tire", cr2w, this);
				}
				return _tire;
			}
			set
			{
				if (_tire == value)
				{
					return;
				}
				_tire = value;
				PropertySet(this);
			}
		}

		public questToggleBrokenTire_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
