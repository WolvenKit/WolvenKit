using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageDigitsGameController : gameuiProjectedHUDGameController
	{
		private CInt32 _maxVisible;
		private CInt32 _maxAccumulatedVisible;
		private wCHandle<gameObject> _realOwner;
		private CHandle<inkScriptFIFOQueue> _digitsQueue;
		private CBool _isBeingUsed;
		private gameSlotWeaponData _activeWeapon;
		private CHandle<gameSlotDataHolder> _bufferedRosterData;
		private CArray<wCHandle<DamageDigitLogicController>> _individualControllerArray;
		private CArray<AccumulatedDamageDigitsNode> _accumulatedControllerArray;
		private CEnum<gameuiDamageDigitsMode> _damageDigitsMode;
		private CBool _showDigitsIndividual;
		private CBool _showDigitsAccumulated;
		private CEnum<gameuiDamageDigitsStickingMode> _damageDigitsStickingMode;
		private wCHandle<gameIBlackboard> _damageInfoBB;
		private wCHandle<gameIBlackboard> _uIBlackboard;
		private CUInt32 _damageListBlackboardId;
		private CUInt32 _bBWeaponListBlackboardId;
		private CUInt32 _damageDigitsModeBlackboardId;
		private CUInt32 _damageDigitsStickingModeBlackboardId;

		[Ordinal(9)] 
		[RED("maxVisible")] 
		public CInt32 MaxVisible
		{
			get
			{
				if (_maxVisible == null)
				{
					_maxVisible = (CInt32) CR2WTypeManager.Create("Int32", "maxVisible", cr2w, this);
				}
				return _maxVisible;
			}
			set
			{
				if (_maxVisible == value)
				{
					return;
				}
				_maxVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maxAccumulatedVisible")] 
		public CInt32 MaxAccumulatedVisible
		{
			get
			{
				if (_maxAccumulatedVisible == null)
				{
					_maxAccumulatedVisible = (CInt32) CR2WTypeManager.Create("Int32", "maxAccumulatedVisible", cr2w, this);
				}
				return _maxAccumulatedVisible;
			}
			set
			{
				if (_maxAccumulatedVisible == value)
				{
					return;
				}
				_maxAccumulatedVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("realOwner")] 
		public wCHandle<gameObject> RealOwner
		{
			get
			{
				if (_realOwner == null)
				{
					_realOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "realOwner", cr2w, this);
				}
				return _realOwner;
			}
			set
			{
				if (_realOwner == value)
				{
					return;
				}
				_realOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("digitsQueue")] 
		public CHandle<inkScriptFIFOQueue> DigitsQueue
		{
			get
			{
				if (_digitsQueue == null)
				{
					_digitsQueue = (CHandle<inkScriptFIFOQueue>) CR2WTypeManager.Create("handle:inkScriptFIFOQueue", "digitsQueue", cr2w, this);
				}
				return _digitsQueue;
			}
			set
			{
				if (_digitsQueue == value)
				{
					return;
				}
				_digitsQueue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isBeingUsed")] 
		public CBool IsBeingUsed
		{
			get
			{
				if (_isBeingUsed == null)
				{
					_isBeingUsed = (CBool) CR2WTypeManager.Create("Bool", "isBeingUsed", cr2w, this);
				}
				return _isBeingUsed;
			}
			set
			{
				if (_isBeingUsed == value)
				{
					return;
				}
				_isBeingUsed = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get
			{
				if (_activeWeapon == null)
				{
					_activeWeapon = (gameSlotWeaponData) CR2WTypeManager.Create("gameSlotWeaponData", "ActiveWeapon", cr2w, this);
				}
				return _activeWeapon;
			}
			set
			{
				if (_activeWeapon == value)
				{
					return;
				}
				_activeWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get
			{
				if (_bufferedRosterData == null)
				{
					_bufferedRosterData = (CHandle<gameSlotDataHolder>) CR2WTypeManager.Create("handle:gameSlotDataHolder", "BufferedRosterData", cr2w, this);
				}
				return _bufferedRosterData;
			}
			set
			{
				if (_bufferedRosterData == value)
				{
					return;
				}
				_bufferedRosterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("individualControllerArray")] 
		public CArray<wCHandle<DamageDigitLogicController>> IndividualControllerArray
		{
			get
			{
				if (_individualControllerArray == null)
				{
					_individualControllerArray = (CArray<wCHandle<DamageDigitLogicController>>) CR2WTypeManager.Create("array:whandle:DamageDigitLogicController", "individualControllerArray", cr2w, this);
				}
				return _individualControllerArray;
			}
			set
			{
				if (_individualControllerArray == value)
				{
					return;
				}
				_individualControllerArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("accumulatedControllerArray")] 
		public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray
		{
			get
			{
				if (_accumulatedControllerArray == null)
				{
					_accumulatedControllerArray = (CArray<AccumulatedDamageDigitsNode>) CR2WTypeManager.Create("array:AccumulatedDamageDigitsNode", "accumulatedControllerArray", cr2w, this);
				}
				return _accumulatedControllerArray;
			}
			set
			{
				if (_accumulatedControllerArray == value)
				{
					return;
				}
				_accumulatedControllerArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("damageDigitsMode")] 
		public CEnum<gameuiDamageDigitsMode> DamageDigitsMode
		{
			get
			{
				if (_damageDigitsMode == null)
				{
					_damageDigitsMode = (CEnum<gameuiDamageDigitsMode>) CR2WTypeManager.Create("gameuiDamageDigitsMode", "damageDigitsMode", cr2w, this);
				}
				return _damageDigitsMode;
			}
			set
			{
				if (_damageDigitsMode == value)
				{
					return;
				}
				_damageDigitsMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("showDigitsIndividual")] 
		public CBool ShowDigitsIndividual
		{
			get
			{
				if (_showDigitsIndividual == null)
				{
					_showDigitsIndividual = (CBool) CR2WTypeManager.Create("Bool", "showDigitsIndividual", cr2w, this);
				}
				return _showDigitsIndividual;
			}
			set
			{
				if (_showDigitsIndividual == value)
				{
					return;
				}
				_showDigitsIndividual = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("showDigitsAccumulated")] 
		public CBool ShowDigitsAccumulated
		{
			get
			{
				if (_showDigitsAccumulated == null)
				{
					_showDigitsAccumulated = (CBool) CR2WTypeManager.Create("Bool", "showDigitsAccumulated", cr2w, this);
				}
				return _showDigitsAccumulated;
			}
			set
			{
				if (_showDigitsAccumulated == value)
				{
					return;
				}
				_showDigitsAccumulated = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("damageDigitsStickingMode")] 
		public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode
		{
			get
			{
				if (_damageDigitsStickingMode == null)
				{
					_damageDigitsStickingMode = (CEnum<gameuiDamageDigitsStickingMode>) CR2WTypeManager.Create("gameuiDamageDigitsStickingMode", "damageDigitsStickingMode", cr2w, this);
				}
				return _damageDigitsStickingMode;
			}
			set
			{
				if (_damageDigitsStickingMode == value)
				{
					return;
				}
				_damageDigitsStickingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("damageInfoBB")] 
		public wCHandle<gameIBlackboard> DamageInfoBB
		{
			get
			{
				if (_damageInfoBB == null)
				{
					_damageInfoBB = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "damageInfoBB", cr2w, this);
				}
				return _damageInfoBB;
			}
			set
			{
				if (_damageInfoBB == value)
				{
					return;
				}
				_damageInfoBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("UIBlackboard")] 
		public wCHandle<gameIBlackboard> UIBlackboard
		{
			get
			{
				if (_uIBlackboard == null)
				{
					_uIBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "UIBlackboard", cr2w, this);
				}
				return _uIBlackboard;
			}
			set
			{
				if (_uIBlackboard == value)
				{
					return;
				}
				_uIBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("damageListBlackboardId")] 
		public CUInt32 DamageListBlackboardId
		{
			get
			{
				if (_damageListBlackboardId == null)
				{
					_damageListBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "damageListBlackboardId", cr2w, this);
				}
				return _damageListBlackboardId;
			}
			set
			{
				if (_damageListBlackboardId == value)
				{
					return;
				}
				_damageListBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("BBWeaponListBlackboardId")] 
		public CUInt32 BBWeaponListBlackboardId
		{
			get
			{
				if (_bBWeaponListBlackboardId == null)
				{
					_bBWeaponListBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "BBWeaponListBlackboardId", cr2w, this);
				}
				return _bBWeaponListBlackboardId;
			}
			set
			{
				if (_bBWeaponListBlackboardId == value)
				{
					return;
				}
				_bBWeaponListBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("damageDigitsModeBlackboardId")] 
		public CUInt32 DamageDigitsModeBlackboardId
		{
			get
			{
				if (_damageDigitsModeBlackboardId == null)
				{
					_damageDigitsModeBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "damageDigitsModeBlackboardId", cr2w, this);
				}
				return _damageDigitsModeBlackboardId;
			}
			set
			{
				if (_damageDigitsModeBlackboardId == value)
				{
					return;
				}
				_damageDigitsModeBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("damageDigitsStickingModeBlackboardId")] 
		public CUInt32 DamageDigitsStickingModeBlackboardId
		{
			get
			{
				if (_damageDigitsStickingModeBlackboardId == null)
				{
					_damageDigitsStickingModeBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "damageDigitsStickingModeBlackboardId", cr2w, this);
				}
				return _damageDigitsStickingModeBlackboardId;
			}
			set
			{
				if (_damageDigitsStickingModeBlackboardId == value)
				{
					return;
				}
				_damageDigitsStickingModeBlackboardId = value;
				PropertySet(this);
			}
		}

		public DamageDigitsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
