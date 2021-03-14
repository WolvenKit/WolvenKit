using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestVisualDestructionEvent : redEvent
	{
		private CBool _accumulate;
		private CFloat _frontLeft;
		private CFloat _frontRight;
		private CFloat _front;
		private CFloat _right;
		private CFloat _left;
		private CFloat _backLeft;
		private CFloat _backRight;
		private CFloat _back;
		private CFloat _roof;

		[Ordinal(0)] 
		[RED("accumulate")] 
		public CBool Accumulate
		{
			get
			{
				if (_accumulate == null)
				{
					_accumulate = (CBool) CR2WTypeManager.Create("Bool", "accumulate", cr2w, this);
				}
				return _accumulate;
			}
			set
			{
				if (_accumulate == value)
				{
					return;
				}
				_accumulate = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("frontLeft")] 
		public CFloat FrontLeft
		{
			get
			{
				if (_frontLeft == null)
				{
					_frontLeft = (CFloat) CR2WTypeManager.Create("Float", "frontLeft", cr2w, this);
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

		[Ordinal(2)] 
		[RED("frontRight")] 
		public CFloat FrontRight
		{
			get
			{
				if (_frontRight == null)
				{
					_frontRight = (CFloat) CR2WTypeManager.Create("Float", "frontRight", cr2w, this);
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

		[Ordinal(3)] 
		[RED("front")] 
		public CFloat Front
		{
			get
			{
				if (_front == null)
				{
					_front = (CFloat) CR2WTypeManager.Create("Float", "front", cr2w, this);
				}
				return _front;
			}
			set
			{
				if (_front == value)
				{
					return;
				}
				_front = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("right")] 
		public CFloat Right
		{
			get
			{
				if (_right == null)
				{
					_right = (CFloat) CR2WTypeManager.Create("Float", "right", cr2w, this);
				}
				return _right;
			}
			set
			{
				if (_right == value)
				{
					return;
				}
				_right = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("left")] 
		public CFloat Left
		{
			get
			{
				if (_left == null)
				{
					_left = (CFloat) CR2WTypeManager.Create("Float", "left", cr2w, this);
				}
				return _left;
			}
			set
			{
				if (_left == value)
				{
					return;
				}
				_left = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("backLeft")] 
		public CFloat BackLeft
		{
			get
			{
				if (_backLeft == null)
				{
					_backLeft = (CFloat) CR2WTypeManager.Create("Float", "backLeft", cr2w, this);
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

		[Ordinal(7)] 
		[RED("backRight")] 
		public CFloat BackRight
		{
			get
			{
				if (_backRight == null)
				{
					_backRight = (CFloat) CR2WTypeManager.Create("Float", "backRight", cr2w, this);
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

		[Ordinal(8)] 
		[RED("back")] 
		public CFloat Back
		{
			get
			{
				if (_back == null)
				{
					_back = (CFloat) CR2WTypeManager.Create("Float", "back", cr2w, this);
				}
				return _back;
			}
			set
			{
				if (_back == value)
				{
					return;
				}
				_back = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("roof")] 
		public CFloat Roof
		{
			get
			{
				if (_roof == null)
				{
					_roof = (CFloat) CR2WTypeManager.Create("Float", "roof", cr2w, this);
				}
				return _roof;
			}
			set
			{
				if (_roof == value)
				{
					return;
				}
				_roof = value;
				PropertySet(this);
			}
		}

		public VehicleQuestVisualDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
