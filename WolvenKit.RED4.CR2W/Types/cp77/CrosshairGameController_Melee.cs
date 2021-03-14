using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Melee : gameuiCrosshairBaseMelee
	{
		private inkWidgetReference _targetColorChange;
		private wCHandle<inkCanvasWidget> _chargeBar;
		private wCHandle<inkRectangleWidget> _chargeBarFG;
		private wCHandle<inkImageWidget> _chargeBarMonoTop;
		private wCHandle<inkImageWidget> _chargeBarMonoBottom;
		private wCHandle<inkMaskWidget> _chargeBarMask;
		private wCHandle<inkTextWidget> _chargeValueL;
		private wCHandle<inkTextWidget> _chargeValueR;
		private CUInt32 _bbcharge;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private CHandle<MeleeResourcePoolListener> _meleeResourcePoolListener;
		private entEntityID _weaponID;
		private CBool _displayChargeBar;

		[Ordinal(20)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get
			{
				if (_targetColorChange == null)
				{
					_targetColorChange = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetColorChange", cr2w, this);
				}
				return _targetColorChange;
			}
			set
			{
				if (_targetColorChange == value)
				{
					return;
				}
				_targetColorChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("chargeBar")] 
		public wCHandle<inkCanvasWidget> ChargeBar
		{
			get
			{
				if (_chargeBar == null)
				{
					_chargeBar = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "chargeBar", cr2w, this);
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
		[RED("chargeBarFG")] 
		public wCHandle<inkRectangleWidget> ChargeBarFG
		{
			get
			{
				if (_chargeBarFG == null)
				{
					_chargeBarFG = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "chargeBarFG", cr2w, this);
				}
				return _chargeBarFG;
			}
			set
			{
				if (_chargeBarFG == value)
				{
					return;
				}
				_chargeBarFG = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("chargeBarMonoTop")] 
		public wCHandle<inkImageWidget> ChargeBarMonoTop
		{
			get
			{
				if (_chargeBarMonoTop == null)
				{
					_chargeBarMonoTop = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "chargeBarMonoTop", cr2w, this);
				}
				return _chargeBarMonoTop;
			}
			set
			{
				if (_chargeBarMonoTop == value)
				{
					return;
				}
				_chargeBarMonoTop = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("chargeBarMonoBottom")] 
		public wCHandle<inkImageWidget> ChargeBarMonoBottom
		{
			get
			{
				if (_chargeBarMonoBottom == null)
				{
					_chargeBarMonoBottom = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "chargeBarMonoBottom", cr2w, this);
				}
				return _chargeBarMonoBottom;
			}
			set
			{
				if (_chargeBarMonoBottom == value)
				{
					return;
				}
				_chargeBarMonoBottom = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("chargeBarMask")] 
		public wCHandle<inkMaskWidget> ChargeBarMask
		{
			get
			{
				if (_chargeBarMask == null)
				{
					_chargeBarMask = (wCHandle<inkMaskWidget>) CR2WTypeManager.Create("whandle:inkMaskWidget", "chargeBarMask", cr2w, this);
				}
				return _chargeBarMask;
			}
			set
			{
				if (_chargeBarMask == value)
				{
					return;
				}
				_chargeBarMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("chargeValueL")] 
		public wCHandle<inkTextWidget> ChargeValueL
		{
			get
			{
				if (_chargeValueL == null)
				{
					_chargeValueL = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "chargeValueL", cr2w, this);
				}
				return _chargeValueL;
			}
			set
			{
				if (_chargeValueL == value)
				{
					return;
				}
				_chargeValueL = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("chargeValueR")] 
		public wCHandle<inkTextWidget> ChargeValueR
		{
			get
			{
				if (_chargeValueR == null)
				{
					_chargeValueR = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "chargeValueR", cr2w, this);
				}
				return _chargeValueR;
			}
			set
			{
				if (_chargeValueR == value)
				{
					return;
				}
				_chargeValueR = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("bbcharge")] 
		public CUInt32 Bbcharge
		{
			get
			{
				if (_bbcharge == null)
				{
					_bbcharge = (CUInt32) CR2WTypeManager.Create("Uint32", "bbcharge", cr2w, this);
				}
				return _bbcharge;
			}
			set
			{
				if (_bbcharge == value)
				{
					return;
				}
				_bbcharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("weaponlocalBB")] 
		public CHandle<gameIBlackboard> WeaponlocalBB
		{
			get
			{
				if (_weaponlocalBB == null)
				{
					_weaponlocalBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "weaponlocalBB", cr2w, this);
				}
				return _weaponlocalBB;
			}
			set
			{
				if (_weaponlocalBB == value)
				{
					return;
				}
				_weaponlocalBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("meleeResourcePoolListener")] 
		public CHandle<MeleeResourcePoolListener> MeleeResourcePoolListener
		{
			get
			{
				if (_meleeResourcePoolListener == null)
				{
					_meleeResourcePoolListener = (CHandle<MeleeResourcePoolListener>) CR2WTypeManager.Create("handle:MeleeResourcePoolListener", "meleeResourcePoolListener", cr2w, this);
				}
				return _meleeResourcePoolListener;
			}
			set
			{
				if (_meleeResourcePoolListener == value)
				{
					return;
				}
				_meleeResourcePoolListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (entEntityID) CR2WTypeManager.Create("entEntityID", "weaponID", cr2w, this);
				}
				return _weaponID;
			}
			set
			{
				if (_weaponID == value)
				{
					return;
				}
				_weaponID = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("displayChargeBar")] 
		public CBool DisplayChargeBar
		{
			get
			{
				if (_displayChargeBar == null)
				{
					_displayChargeBar = (CBool) CR2WTypeManager.Create("Bool", "displayChargeBar", cr2w, this);
				}
				return _displayChargeBar;
			}
			set
			{
				if (_displayChargeBar == value)
				{
					return;
				}
				_displayChargeBar = value;
				PropertySet(this);
			}
		}

		public CrosshairGameController_Melee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
