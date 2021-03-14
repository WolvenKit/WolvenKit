using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_QuickSlotsDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _uIRadialContextRequest;
		private gamebbScriptID_Float _uIRadialContextRightStickAngle;
		private gamebbScriptID_Vector4 _leftStick;
		private gamebbScriptID_Variant _dPadCommand;
		private gamebbScriptID_Variant _keyboardCommand;
		private gamebbScriptID_Variant _wheelInteractionStarted;
		private gamebbScriptID_Variant _wheelInteractionEnded;
		private gamebbScriptID_Bool _cyberwareAssignmentComplete;
		private gamebbScriptID_Bool _wheelAssignmentComplete;
		private gamebbScriptID_Variant _quickSlotsStructure;
		private gamebbScriptID_Variant _activeQuickSlotItem;
		private gamebbScriptID_Int32 _quickSlotsActiveWeaponIndex;
		private gamebbScriptID_Bool _quickhackPanelOpen;
		private gamebbScriptID_Bool _quickHackDescritpionVisible;
		private gamebbScriptID_Variant _quickHackDataSelected;
		private gamebbScriptID_Bool _dpadHintRefresh;
		private gamebbScriptID_Variant _containerConsumable;
		private gamebbScriptID_Variant _consumableBeingUsed;

		[Ordinal(0)] 
		[RED("UIRadialContextRequest")] 
		public gamebbScriptID_Bool UIRadialContextRequest
		{
			get
			{
				if (_uIRadialContextRequest == null)
				{
					_uIRadialContextRequest = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UIRadialContextRequest", cr2w, this);
				}
				return _uIRadialContextRequest;
			}
			set
			{
				if (_uIRadialContextRequest == value)
				{
					return;
				}
				_uIRadialContextRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("UIRadialContextRightStickAngle")] 
		public gamebbScriptID_Float UIRadialContextRightStickAngle
		{
			get
			{
				if (_uIRadialContextRightStickAngle == null)
				{
					_uIRadialContextRightStickAngle = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "UIRadialContextRightStickAngle", cr2w, this);
				}
				return _uIRadialContextRightStickAngle;
			}
			set
			{
				if (_uIRadialContextRightStickAngle == value)
				{
					return;
				}
				_uIRadialContextRightStickAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("leftStick")] 
		public gamebbScriptID_Vector4 LeftStick
		{
			get
			{
				if (_leftStick == null)
				{
					_leftStick = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "leftStick", cr2w, this);
				}
				return _leftStick;
			}
			set
			{
				if (_leftStick == value)
				{
					return;
				}
				_leftStick = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("DPadCommand")] 
		public gamebbScriptID_Variant DPadCommand
		{
			get
			{
				if (_dPadCommand == null)
				{
					_dPadCommand = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DPadCommand", cr2w, this);
				}
				return _dPadCommand;
			}
			set
			{
				if (_dPadCommand == value)
				{
					return;
				}
				_dPadCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("KeyboardCommand")] 
		public gamebbScriptID_Variant KeyboardCommand
		{
			get
			{
				if (_keyboardCommand == null)
				{
					_keyboardCommand = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "KeyboardCommand", cr2w, this);
				}
				return _keyboardCommand;
			}
			set
			{
				if (_keyboardCommand == value)
				{
					return;
				}
				_keyboardCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("WheelInteractionStarted")] 
		public gamebbScriptID_Variant WheelInteractionStarted
		{
			get
			{
				if (_wheelInteractionStarted == null)
				{
					_wheelInteractionStarted = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "WheelInteractionStarted", cr2w, this);
				}
				return _wheelInteractionStarted;
			}
			set
			{
				if (_wheelInteractionStarted == value)
				{
					return;
				}
				_wheelInteractionStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("WheelInteractionEnded")] 
		public gamebbScriptID_Variant WheelInteractionEnded
		{
			get
			{
				if (_wheelInteractionEnded == null)
				{
					_wheelInteractionEnded = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "WheelInteractionEnded", cr2w, this);
				}
				return _wheelInteractionEnded;
			}
			set
			{
				if (_wheelInteractionEnded == value)
				{
					return;
				}
				_wheelInteractionEnded = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("CyberwareAssignmentComplete")] 
		public gamebbScriptID_Bool CyberwareAssignmentComplete
		{
			get
			{
				if (_cyberwareAssignmentComplete == null)
				{
					_cyberwareAssignmentComplete = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "CyberwareAssignmentComplete", cr2w, this);
				}
				return _cyberwareAssignmentComplete;
			}
			set
			{
				if (_cyberwareAssignmentComplete == value)
				{
					return;
				}
				_cyberwareAssignmentComplete = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("WheelAssignmentComplete")] 
		public gamebbScriptID_Bool WheelAssignmentComplete
		{
			get
			{
				if (_wheelAssignmentComplete == null)
				{
					_wheelAssignmentComplete = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "WheelAssignmentComplete", cr2w, this);
				}
				return _wheelAssignmentComplete;
			}
			set
			{
				if (_wheelAssignmentComplete == value)
				{
					return;
				}
				_wheelAssignmentComplete = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("quickSlotsStructure")] 
		public gamebbScriptID_Variant QuickSlotsStructure
		{
			get
			{
				if (_quickSlotsStructure == null)
				{
					_quickSlotsStructure = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "quickSlotsStructure", cr2w, this);
				}
				return _quickSlotsStructure;
			}
			set
			{
				if (_quickSlotsStructure == value)
				{
					return;
				}
				_quickSlotsStructure = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("activeQuickSlotItem")] 
		public gamebbScriptID_Variant ActiveQuickSlotItem
		{
			get
			{
				if (_activeQuickSlotItem == null)
				{
					_activeQuickSlotItem = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "activeQuickSlotItem", cr2w, this);
				}
				return _activeQuickSlotItem;
			}
			set
			{
				if (_activeQuickSlotItem == value)
				{
					return;
				}
				_activeQuickSlotItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("quickSlotsActiveWeaponIndex")] 
		public gamebbScriptID_Int32 QuickSlotsActiveWeaponIndex
		{
			get
			{
				if (_quickSlotsActiveWeaponIndex == null)
				{
					_quickSlotsActiveWeaponIndex = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "quickSlotsActiveWeaponIndex", cr2w, this);
				}
				return _quickSlotsActiveWeaponIndex;
			}
			set
			{
				if (_quickSlotsActiveWeaponIndex == value)
				{
					return;
				}
				_quickSlotsActiveWeaponIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("quickhackPanelOpen")] 
		public gamebbScriptID_Bool QuickhackPanelOpen
		{
			get
			{
				if (_quickhackPanelOpen == null)
				{
					_quickhackPanelOpen = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "quickhackPanelOpen", cr2w, this);
				}
				return _quickhackPanelOpen;
			}
			set
			{
				if (_quickhackPanelOpen == value)
				{
					return;
				}
				_quickhackPanelOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("quickHackDescritpionVisible")] 
		public gamebbScriptID_Bool QuickHackDescritpionVisible
		{
			get
			{
				if (_quickHackDescritpionVisible == null)
				{
					_quickHackDescritpionVisible = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "quickHackDescritpionVisible", cr2w, this);
				}
				return _quickHackDescritpionVisible;
			}
			set
			{
				if (_quickHackDescritpionVisible == value)
				{
					return;
				}
				_quickHackDescritpionVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("quickHackDataSelected")] 
		public gamebbScriptID_Variant QuickHackDataSelected
		{
			get
			{
				if (_quickHackDataSelected == null)
				{
					_quickHackDataSelected = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "quickHackDataSelected", cr2w, this);
				}
				return _quickHackDataSelected;
			}
			set
			{
				if (_quickHackDataSelected == value)
				{
					return;
				}
				_quickHackDataSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("dpadHintRefresh")] 
		public gamebbScriptID_Bool DpadHintRefresh
		{
			get
			{
				if (_dpadHintRefresh == null)
				{
					_dpadHintRefresh = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "dpadHintRefresh", cr2w, this);
				}
				return _dpadHintRefresh;
			}
			set
			{
				if (_dpadHintRefresh == value)
				{
					return;
				}
				_dpadHintRefresh = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("containerConsumable")] 
		public gamebbScriptID_Variant ContainerConsumable
		{
			get
			{
				if (_containerConsumable == null)
				{
					_containerConsumable = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "containerConsumable", cr2w, this);
				}
				return _containerConsumable;
			}
			set
			{
				if (_containerConsumable == value)
				{
					return;
				}
				_containerConsumable = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("consumableBeingUsed")] 
		public gamebbScriptID_Variant ConsumableBeingUsed
		{
			get
			{
				if (_consumableBeingUsed == null)
				{
					_consumableBeingUsed = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "consumableBeingUsed", cr2w, this);
				}
				return _consumableBeingUsed;
			}
			set
			{
				if (_consumableBeingUsed == value)
				{
					return;
				}
				_consumableBeingUsed = value;
				PropertySet(this);
			}
		}

		public UI_QuickSlotsDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
