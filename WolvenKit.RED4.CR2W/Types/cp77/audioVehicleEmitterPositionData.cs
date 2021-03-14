using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleEmitterPositionData : CVariable
	{
		private Vector3 _engineEmitterPosition;
		private Vector3 _exaustEmitterPosition;
		private Vector3 _centralEmitterPosition;
		private Vector3 _hoodEmitterPosition;
		private Vector3 _trunkEmitterPosition;
		private Vector3 _wheel1Position;
		private Vector3 _wheel2Position;
		private Vector3 _wheel3Position;
		private Vector3 _wheel4Position;

		[Ordinal(0)] 
		[RED("engineEmitterPosition")] 
		public Vector3 EngineEmitterPosition
		{
			get
			{
				if (_engineEmitterPosition == null)
				{
					_engineEmitterPosition = (Vector3) CR2WTypeManager.Create("Vector3", "engineEmitterPosition", cr2w, this);
				}
				return _engineEmitterPosition;
			}
			set
			{
				if (_engineEmitterPosition == value)
				{
					return;
				}
				_engineEmitterPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("exaustEmitterPosition")] 
		public Vector3 ExaustEmitterPosition
		{
			get
			{
				if (_exaustEmitterPosition == null)
				{
					_exaustEmitterPosition = (Vector3) CR2WTypeManager.Create("Vector3", "exaustEmitterPosition", cr2w, this);
				}
				return _exaustEmitterPosition;
			}
			set
			{
				if (_exaustEmitterPosition == value)
				{
					return;
				}
				_exaustEmitterPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("centralEmitterPosition")] 
		public Vector3 CentralEmitterPosition
		{
			get
			{
				if (_centralEmitterPosition == null)
				{
					_centralEmitterPosition = (Vector3) CR2WTypeManager.Create("Vector3", "centralEmitterPosition", cr2w, this);
				}
				return _centralEmitterPosition;
			}
			set
			{
				if (_centralEmitterPosition == value)
				{
					return;
				}
				_centralEmitterPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hoodEmitterPosition")] 
		public Vector3 HoodEmitterPosition
		{
			get
			{
				if (_hoodEmitterPosition == null)
				{
					_hoodEmitterPosition = (Vector3) CR2WTypeManager.Create("Vector3", "hoodEmitterPosition", cr2w, this);
				}
				return _hoodEmitterPosition;
			}
			set
			{
				if (_hoodEmitterPosition == value)
				{
					return;
				}
				_hoodEmitterPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("trunkEmitterPosition")] 
		public Vector3 TrunkEmitterPosition
		{
			get
			{
				if (_trunkEmitterPosition == null)
				{
					_trunkEmitterPosition = (Vector3) CR2WTypeManager.Create("Vector3", "trunkEmitterPosition", cr2w, this);
				}
				return _trunkEmitterPosition;
			}
			set
			{
				if (_trunkEmitterPosition == value)
				{
					return;
				}
				_trunkEmitterPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("wheel1Position")] 
		public Vector3 Wheel1Position
		{
			get
			{
				if (_wheel1Position == null)
				{
					_wheel1Position = (Vector3) CR2WTypeManager.Create("Vector3", "wheel1Position", cr2w, this);
				}
				return _wheel1Position;
			}
			set
			{
				if (_wheel1Position == value)
				{
					return;
				}
				_wheel1Position = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("wheel2Position")] 
		public Vector3 Wheel2Position
		{
			get
			{
				if (_wheel2Position == null)
				{
					_wheel2Position = (Vector3) CR2WTypeManager.Create("Vector3", "wheel2Position", cr2w, this);
				}
				return _wheel2Position;
			}
			set
			{
				if (_wheel2Position == value)
				{
					return;
				}
				_wheel2Position = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("wheel3Position")] 
		public Vector3 Wheel3Position
		{
			get
			{
				if (_wheel3Position == null)
				{
					_wheel3Position = (Vector3) CR2WTypeManager.Create("Vector3", "wheel3Position", cr2w, this);
				}
				return _wheel3Position;
			}
			set
			{
				if (_wheel3Position == value)
				{
					return;
				}
				_wheel3Position = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("wheel4Position")] 
		public Vector3 Wheel4Position
		{
			get
			{
				if (_wheel4Position == null)
				{
					_wheel4Position = (Vector3) CR2WTypeManager.Create("Vector3", "wheel4Position", cr2w, this);
				}
				return _wheel4Position;
			}
			set
			{
				if (_wheel4Position == value)
				{
					return;
				}
				_wheel4Position = value;
				PropertySet(this);
			}
		}

		public audioVehicleEmitterPositionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
