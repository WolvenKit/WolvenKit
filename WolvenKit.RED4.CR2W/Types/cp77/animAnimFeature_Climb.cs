using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Climb : animAnimFeature
	{
		private Vector4 _verticalPosition;
		private Vector4 _horizontalPosition;
		private CFloat _toVerticalTime;
		private CFloat _verticalToHorizontalTime;
		private Vector4 _frontEdgePosition;
		private Vector4 _frontEdgeNormal;
		private CFloat _yawAngle;
		private CFloat _stateLength;
		private CInt32 _climbType;
		private CInt32 _state;

		[Ordinal(0)] 
		[RED("verticalPosition")] 
		public Vector4 VerticalPosition
		{
			get
			{
				if (_verticalPosition == null)
				{
					_verticalPosition = (Vector4) CR2WTypeManager.Create("Vector4", "verticalPosition", cr2w, this);
				}
				return _verticalPosition;
			}
			set
			{
				if (_verticalPosition == value)
				{
					return;
				}
				_verticalPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("horizontalPosition")] 
		public Vector4 HorizontalPosition
		{
			get
			{
				if (_horizontalPosition == null)
				{
					_horizontalPosition = (Vector4) CR2WTypeManager.Create("Vector4", "horizontalPosition", cr2w, this);
				}
				return _horizontalPosition;
			}
			set
			{
				if (_horizontalPosition == value)
				{
					return;
				}
				_horizontalPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("toVerticalTime")] 
		public CFloat ToVerticalTime
		{
			get
			{
				if (_toVerticalTime == null)
				{
					_toVerticalTime = (CFloat) CR2WTypeManager.Create("Float", "toVerticalTime", cr2w, this);
				}
				return _toVerticalTime;
			}
			set
			{
				if (_toVerticalTime == value)
				{
					return;
				}
				_toVerticalTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("verticalToHorizontalTime")] 
		public CFloat VerticalToHorizontalTime
		{
			get
			{
				if (_verticalToHorizontalTime == null)
				{
					_verticalToHorizontalTime = (CFloat) CR2WTypeManager.Create("Float", "verticalToHorizontalTime", cr2w, this);
				}
				return _verticalToHorizontalTime;
			}
			set
			{
				if (_verticalToHorizontalTime == value)
				{
					return;
				}
				_verticalToHorizontalTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("frontEdgePosition")] 
		public Vector4 FrontEdgePosition
		{
			get
			{
				if (_frontEdgePosition == null)
				{
					_frontEdgePosition = (Vector4) CR2WTypeManager.Create("Vector4", "frontEdgePosition", cr2w, this);
				}
				return _frontEdgePosition;
			}
			set
			{
				if (_frontEdgePosition == value)
				{
					return;
				}
				_frontEdgePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("frontEdgeNormal")] 
		public Vector4 FrontEdgeNormal
		{
			get
			{
				if (_frontEdgeNormal == null)
				{
					_frontEdgeNormal = (Vector4) CR2WTypeManager.Create("Vector4", "frontEdgeNormal", cr2w, this);
				}
				return _frontEdgeNormal;
			}
			set
			{
				if (_frontEdgeNormal == value)
				{
					return;
				}
				_frontEdgeNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("yawAngle")] 
		public CFloat YawAngle
		{
			get
			{
				if (_yawAngle == null)
				{
					_yawAngle = (CFloat) CR2WTypeManager.Create("Float", "yawAngle", cr2w, this);
				}
				return _yawAngle;
			}
			set
			{
				if (_yawAngle == value)
				{
					return;
				}
				_yawAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stateLength")] 
		public CFloat StateLength
		{
			get
			{
				if (_stateLength == null)
				{
					_stateLength = (CFloat) CR2WTypeManager.Create("Float", "stateLength", cr2w, this);
				}
				return _stateLength;
			}
			set
			{
				if (_stateLength == value)
				{
					return;
				}
				_stateLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("climbType")] 
		public CInt32 ClimbType
		{
			get
			{
				if (_climbType == null)
				{
					_climbType = (CInt32) CR2WTypeManager.Create("Int32", "climbType", cr2w, this);
				}
				return _climbType;
			}
			set
			{
				if (_climbType == value)
				{
					return;
				}
				_climbType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Climb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
