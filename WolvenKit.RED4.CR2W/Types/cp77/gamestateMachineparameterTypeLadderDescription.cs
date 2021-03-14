using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeLadderDescription : IScriptable
	{
		private Vector4 _position;
		private Vector4 _normal;
		private Vector4 _up;
		private CFloat _topHeightFromPosition;
		private CFloat _exitStepTop;
		private CFloat _verticalStepTop;
		private CFloat _exitStepBottom;
		private CFloat _verticalStepBottom;
		private CFloat _exitStepJump;
		private CFloat _verticalStepJump;
		private CFloat _enterOffset;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector4 Normal
		{
			get
			{
				if (_normal == null)
				{
					_normal = (Vector4) CR2WTypeManager.Create("Vector4", "normal", cr2w, this);
				}
				return _normal;
			}
			set
			{
				if (_normal == value)
				{
					return;
				}
				_normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("up")] 
		public Vector4 Up
		{
			get
			{
				if (_up == null)
				{
					_up = (Vector4) CR2WTypeManager.Create("Vector4", "up", cr2w, this);
				}
				return _up;
			}
			set
			{
				if (_up == value)
				{
					return;
				}
				_up = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("topHeightFromPosition")] 
		public CFloat TopHeightFromPosition
		{
			get
			{
				if (_topHeightFromPosition == null)
				{
					_topHeightFromPosition = (CFloat) CR2WTypeManager.Create("Float", "topHeightFromPosition", cr2w, this);
				}
				return _topHeightFromPosition;
			}
			set
			{
				if (_topHeightFromPosition == value)
				{
					return;
				}
				_topHeightFromPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exitStepTop")] 
		public CFloat ExitStepTop
		{
			get
			{
				if (_exitStepTop == null)
				{
					_exitStepTop = (CFloat) CR2WTypeManager.Create("Float", "exitStepTop", cr2w, this);
				}
				return _exitStepTop;
			}
			set
			{
				if (_exitStepTop == value)
				{
					return;
				}
				_exitStepTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("verticalStepTop")] 
		public CFloat VerticalStepTop
		{
			get
			{
				if (_verticalStepTop == null)
				{
					_verticalStepTop = (CFloat) CR2WTypeManager.Create("Float", "verticalStepTop", cr2w, this);
				}
				return _verticalStepTop;
			}
			set
			{
				if (_verticalStepTop == value)
				{
					return;
				}
				_verticalStepTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("exitStepBottom")] 
		public CFloat ExitStepBottom
		{
			get
			{
				if (_exitStepBottom == null)
				{
					_exitStepBottom = (CFloat) CR2WTypeManager.Create("Float", "exitStepBottom", cr2w, this);
				}
				return _exitStepBottom;
			}
			set
			{
				if (_exitStepBottom == value)
				{
					return;
				}
				_exitStepBottom = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("verticalStepBottom")] 
		public CFloat VerticalStepBottom
		{
			get
			{
				if (_verticalStepBottom == null)
				{
					_verticalStepBottom = (CFloat) CR2WTypeManager.Create("Float", "verticalStepBottom", cr2w, this);
				}
				return _verticalStepBottom;
			}
			set
			{
				if (_verticalStepBottom == value)
				{
					return;
				}
				_verticalStepBottom = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("exitStepJump")] 
		public CFloat ExitStepJump
		{
			get
			{
				if (_exitStepJump == null)
				{
					_exitStepJump = (CFloat) CR2WTypeManager.Create("Float", "exitStepJump", cr2w, this);
				}
				return _exitStepJump;
			}
			set
			{
				if (_exitStepJump == value)
				{
					return;
				}
				_exitStepJump = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("verticalStepJump")] 
		public CFloat VerticalStepJump
		{
			get
			{
				if (_verticalStepJump == null)
				{
					_verticalStepJump = (CFloat) CR2WTypeManager.Create("Float", "verticalStepJump", cr2w, this);
				}
				return _verticalStepJump;
			}
			set
			{
				if (_verticalStepJump == value)
				{
					return;
				}
				_verticalStepJump = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("enterOffset")] 
		public CFloat EnterOffset
		{
			get
			{
				if (_enterOffset == null)
				{
					_enterOffset = (CFloat) CR2WTypeManager.Create("Float", "enterOffset", cr2w, this);
				}
				return _enterOffset;
			}
			set
			{
				if (_enterOffset == value)
				{
					return;
				}
				_enterOffset = value;
				PropertySet(this);
			}
		}

		public gamestateMachineparameterTypeLadderDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
