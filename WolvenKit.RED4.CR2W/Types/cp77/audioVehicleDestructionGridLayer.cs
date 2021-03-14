using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDestructionGridLayer : CVariable
	{
		private audioVehicleDestructionGridCell _backLeft;
		private audioVehicleDestructionGridCell _backRight;
		private audioVehicleDestructionGridCell _centerBackLeft;
		private audioVehicleDestructionGridCell _centerBackRight;
		private audioVehicleDestructionGridCell _centerForwardLeft;
		private audioVehicleDestructionGridCell _centerForwardRight;
		private audioVehicleDestructionGridCell _frontLeft;
		private audioVehicleDestructionGridCell _frontRight;

		[Ordinal(0)] 
		[RED("backLeft")] 
		public audioVehicleDestructionGridCell BackLeft
		{
			get
			{
				if (_backLeft == null)
				{
					_backLeft = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "backLeft", cr2w, this);
				}
				return _backLeft;
			}
			set
			{
				if (_backLeft == value)
				{
					return;
				}
				_backLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("backRight")] 
		public audioVehicleDestructionGridCell BackRight
		{
			get
			{
				if (_backRight == null)
				{
					_backRight = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "backRight", cr2w, this);
				}
				return _backRight;
			}
			set
			{
				if (_backRight == value)
				{
					return;
				}
				_backRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("centerBackLeft")] 
		public audioVehicleDestructionGridCell CenterBackLeft
		{
			get
			{
				if (_centerBackLeft == null)
				{
					_centerBackLeft = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "centerBackLeft", cr2w, this);
				}
				return _centerBackLeft;
			}
			set
			{
				if (_centerBackLeft == value)
				{
					return;
				}
				_centerBackLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("centerBackRight")] 
		public audioVehicleDestructionGridCell CenterBackRight
		{
			get
			{
				if (_centerBackRight == null)
				{
					_centerBackRight = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "centerBackRight", cr2w, this);
				}
				return _centerBackRight;
			}
			set
			{
				if (_centerBackRight == value)
				{
					return;
				}
				_centerBackRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("centerForwardLeft")] 
		public audioVehicleDestructionGridCell CenterForwardLeft
		{
			get
			{
				if (_centerForwardLeft == null)
				{
					_centerForwardLeft = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "centerForwardLeft", cr2w, this);
				}
				return _centerForwardLeft;
			}
			set
			{
				if (_centerForwardLeft == value)
				{
					return;
				}
				_centerForwardLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("centerForwardRight")] 
		public audioVehicleDestructionGridCell CenterForwardRight
		{
			get
			{
				if (_centerForwardRight == null)
				{
					_centerForwardRight = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "centerForwardRight", cr2w, this);
				}
				return _centerForwardRight;
			}
			set
			{
				if (_centerForwardRight == value)
				{
					return;
				}
				_centerForwardRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("frontLeft")] 
		public audioVehicleDestructionGridCell FrontLeft
		{
			get
			{
				if (_frontLeft == null)
				{
					_frontLeft = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "frontLeft", cr2w, this);
				}
				return _frontLeft;
			}
			set
			{
				if (_frontLeft == value)
				{
					return;
				}
				_frontLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("frontRight")] 
		public audioVehicleDestructionGridCell FrontRight
		{
			get
			{
				if (_frontRight == null)
				{
					_frontRight = (audioVehicleDestructionGridCell) CR2WTypeManager.Create("audioVehicleDestructionGridCell", "frontRight", cr2w, this);
				}
				return _frontRight;
			}
			set
			{
				if (_frontRight == value)
				{
					return;
				}
				_frontRight = value;
				PropertySet(this);
			}
		}

		public audioVehicleDestructionGridLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
