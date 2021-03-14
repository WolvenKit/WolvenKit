using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompassController : inkWidgetLogicController
	{
		private inkWidgetReference _faceLeft;
		private inkWidgetReference _faceRight;
		private inkTextWidgetReference _textWidget;
		private CUInt32 _decimalPrecision;
		private Vector2 _faceRightStartPosition;
		private Vector2 _faceLeftStartPosition;
		private CBool _isVertical;
		private wCHandle<gameObject> _playerPuppet;

		[Ordinal(1)] 
		[RED("faceLeft")] 
		public inkWidgetReference FaceLeft
		{
			get
			{
				if (_faceLeft == null)
				{
					_faceLeft = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "faceLeft", cr2w, this);
				}
				return _faceLeft;
			}
			set
			{
				if (_faceLeft == value)
				{
					return;
				}
				_faceLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("faceRight")] 
		public inkWidgetReference FaceRight
		{
			get
			{
				if (_faceRight == null)
				{
					_faceRight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "faceRight", cr2w, this);
				}
				return _faceRight;
			}
			set
			{
				if (_faceRight == value)
				{
					return;
				}
				_faceRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textWidget", cr2w, this);
				}
				return _textWidget;
			}
			set
			{
				if (_textWidget == value)
				{
					return;
				}
				_textWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("decimalPrecision")] 
		public CUInt32 DecimalPrecision
		{
			get
			{
				if (_decimalPrecision == null)
				{
					_decimalPrecision = (CUInt32) CR2WTypeManager.Create("Uint32", "decimalPrecision", cr2w, this);
				}
				return _decimalPrecision;
			}
			set
			{
				if (_decimalPrecision == value)
				{
					return;
				}
				_decimalPrecision = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("faceRightStartPosition")] 
		public Vector2 FaceRightStartPosition
		{
			get
			{
				if (_faceRightStartPosition == null)
				{
					_faceRightStartPosition = (Vector2) CR2WTypeManager.Create("Vector2", "faceRightStartPosition", cr2w, this);
				}
				return _faceRightStartPosition;
			}
			set
			{
				if (_faceRightStartPosition == value)
				{
					return;
				}
				_faceRightStartPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("faceLeftStartPosition")] 
		public Vector2 FaceLeftStartPosition
		{
			get
			{
				if (_faceLeftStartPosition == null)
				{
					_faceLeftStartPosition = (Vector2) CR2WTypeManager.Create("Vector2", "faceLeftStartPosition", cr2w, this);
				}
				return _faceLeftStartPosition;
			}
			set
			{
				if (_faceLeftStartPosition == value)
				{
					return;
				}
				_faceLeftStartPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isVertical")] 
		public CBool IsVertical
		{
			get
			{
				if (_isVertical == null)
				{
					_isVertical = (CBool) CR2WTypeManager.Create("Bool", "isVertical", cr2w, this);
				}
				return _isVertical;
			}
			set
			{
				if (_isVertical == value)
				{
					return;
				}
				_isVertical = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		public CompassController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
