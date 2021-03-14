using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Tech_Omaha : gameuiCrosshairBaseGameController
	{
		private wCHandle<inkWidget> _leftPart;
		private wCHandle<inkWidget> _rightPart;
		private wCHandle<inkWidget> _topPart;
		private wCHandle<inkRectangleWidget> _chargeBar;
		private Vector2 _sizeOfChargeBar;
		private CUInt32 _chargeBBID;

		[Ordinal(18)] 
		[RED("leftPart")] 
		public wCHandle<inkWidget> LeftPart
		{
			get
			{
				if (_leftPart == null)
				{
					_leftPart = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "leftPart", cr2w, this);
				}
				return _leftPart;
			}
			set
			{
				if (_leftPart == value)
				{
					return;
				}
				_leftPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public wCHandle<inkWidget> RightPart
		{
			get
			{
				if (_rightPart == null)
				{
					_rightPart = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rightPart", cr2w, this);
				}
				return _rightPart;
			}
			set
			{
				if (_rightPart == value)
				{
					return;
				}
				_rightPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("topPart")] 
		public wCHandle<inkWidget> TopPart
		{
			get
			{
				if (_topPart == null)
				{
					_topPart = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "topPart", cr2w, this);
				}
				return _topPart;
			}
			set
			{
				if (_topPart == value)
				{
					return;
				}
				_topPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("chargeBar")] 
		public wCHandle<inkRectangleWidget> ChargeBar
		{
			get
			{
				if (_chargeBar == null)
				{
					_chargeBar = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "chargeBar", cr2w, this);
				}
				return _chargeBar;
			}
			set
			{
				if (_chargeBar == value)
				{
					return;
				}
				_chargeBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("sizeOfChargeBar")] 
		public Vector2 SizeOfChargeBar
		{
			get
			{
				if (_sizeOfChargeBar == null)
				{
					_sizeOfChargeBar = (Vector2) CR2WTypeManager.Create("Vector2", "sizeOfChargeBar", cr2w, this);
				}
				return _sizeOfChargeBar;
			}
			set
			{
				if (_sizeOfChargeBar == value)
				{
					return;
				}
				_sizeOfChargeBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("chargeBBID")] 
		public CUInt32 ChargeBBID
		{
			get
			{
				if (_chargeBBID == null)
				{
					_chargeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "chargeBBID", cr2w, this);
				}
				return _chargeBBID;
			}
			set
			{
				if (_chargeBBID == value)
				{
					return;
				}
				_chargeBBID = value;
				PropertySet(this);
			}
		}

		public Crosshair_Tech_Omaha(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
