using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AltimeterController : inkWidgetLogicController
	{
		private inkWidgetReference _faceUp;
		private inkWidgetReference _faceDown;
		private inkTextWidgetReference _textWidget;
		private CUInt32 _decimalPrecision;
		private Vector2 _faceUpStartPosition;
		private Vector2 _faceDownStartPosition;
		private wCHandle<gameObject> _playerPuppet;
		private CFloat _warpDistance;

		[Ordinal(1)] 
		[RED("faceUp")] 
		public inkWidgetReference FaceUp
		{
			get
			{
				if (_faceUp == null)
				{
					_faceUp = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "faceUp", cr2w, this);
				}
				return _faceUp;
			}
			set
			{
				if (_faceUp == value)
				{
					return;
				}
				_faceUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("faceDown")] 
		public inkWidgetReference FaceDown
		{
			get
			{
				if (_faceDown == null)
				{
					_faceDown = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "faceDown", cr2w, this);
				}
				return _faceDown;
			}
			set
			{
				if (_faceDown == value)
				{
					return;
				}
				_faceDown = value;
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
		[RED("faceUpStartPosition")] 
		public Vector2 FaceUpStartPosition
		{
			get
			{
				if (_faceUpStartPosition == null)
				{
					_faceUpStartPosition = (Vector2) CR2WTypeManager.Create("Vector2", "faceUpStartPosition", cr2w, this);
				}
				return _faceUpStartPosition;
			}
			set
			{
				if (_faceUpStartPosition == value)
				{
					return;
				}
				_faceUpStartPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("faceDownStartPosition")] 
		public Vector2 FaceDownStartPosition
		{
			get
			{
				if (_faceDownStartPosition == null)
				{
					_faceDownStartPosition = (Vector2) CR2WTypeManager.Create("Vector2", "faceDownStartPosition", cr2w, this);
				}
				return _faceDownStartPosition;
			}
			set
			{
				if (_faceDownStartPosition == value)
				{
					return;
				}
				_faceDownStartPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("warpDistance")] 
		public CFloat WarpDistance
		{
			get
			{
				if (_warpDistance == null)
				{
					_warpDistance = (CFloat) CR2WTypeManager.Create("Float", "warpDistance", cr2w, this);
				}
				return _warpDistance;
			}
			set
			{
				if (_warpDistance == value)
				{
					return;
				}
				_warpDistance = value;
				PropertySet(this);
			}
		}

		public AltimeterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
