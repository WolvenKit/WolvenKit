using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotMachineController : inkWidgetLogicController
	{
		private CName _barrelAnimationID;
		private CArray<CName> _winAnimationsID;
		private CName _looseAnimationID;
		private CArray<inkWidgetReference> _slotWidgets;
		private CArray<CName> _imagePresets;
		private CInt32 _winChance;
		private CInt32 _maxWinChance;
		private CArray<wCHandle<SlotMachineSlot>> _slots;
		private CHandle<inkanimProxy> _barellAnimation;
		private CHandle<inkanimProxy> _outcomeAnimation;
		private CBool _shouldWinNextTime;

		[Ordinal(1)] 
		[RED("barrelAnimationID")] 
		public CName BarrelAnimationID
		{
			get
			{
				if (_barrelAnimationID == null)
				{
					_barrelAnimationID = (CName) CR2WTypeManager.Create("CName", "barrelAnimationID", cr2w, this);
				}
				return _barrelAnimationID;
			}
			set
			{
				if (_barrelAnimationID == value)
				{
					return;
				}
				_barrelAnimationID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("winAnimationsID")] 
		public CArray<CName> WinAnimationsID
		{
			get
			{
				if (_winAnimationsID == null)
				{
					_winAnimationsID = (CArray<CName>) CR2WTypeManager.Create("array:CName", "winAnimationsID", cr2w, this);
				}
				return _winAnimationsID;
			}
			set
			{
				if (_winAnimationsID == value)
				{
					return;
				}
				_winAnimationsID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("looseAnimationID")] 
		public CName LooseAnimationID
		{
			get
			{
				if (_looseAnimationID == null)
				{
					_looseAnimationID = (CName) CR2WTypeManager.Create("CName", "looseAnimationID", cr2w, this);
				}
				return _looseAnimationID;
			}
			set
			{
				if (_looseAnimationID == value)
				{
					return;
				}
				_looseAnimationID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slotWidgets")] 
		public CArray<inkWidgetReference> SlotWidgets
		{
			get
			{
				if (_slotWidgets == null)
				{
					_slotWidgets = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "slotWidgets", cr2w, this);
				}
				return _slotWidgets;
			}
			set
			{
				if (_slotWidgets == value)
				{
					return;
				}
				_slotWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("imagePresets")] 
		public CArray<CName> ImagePresets
		{
			get
			{
				if (_imagePresets == null)
				{
					_imagePresets = (CArray<CName>) CR2WTypeManager.Create("array:CName", "imagePresets", cr2w, this);
				}
				return _imagePresets;
			}
			set
			{
				if (_imagePresets == value)
				{
					return;
				}
				_imagePresets = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("winChance")] 
		public CInt32 WinChance
		{
			get
			{
				if (_winChance == null)
				{
					_winChance = (CInt32) CR2WTypeManager.Create("Int32", "winChance", cr2w, this);
				}
				return _winChance;
			}
			set
			{
				if (_winChance == value)
				{
					return;
				}
				_winChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxWinChance")] 
		public CInt32 MaxWinChance
		{
			get
			{
				if (_maxWinChance == null)
				{
					_maxWinChance = (CInt32) CR2WTypeManager.Create("Int32", "maxWinChance", cr2w, this);
				}
				return _maxWinChance;
			}
			set
			{
				if (_maxWinChance == value)
				{
					return;
				}
				_maxWinChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("slots")] 
		public CArray<wCHandle<SlotMachineSlot>> Slots
		{
			get
			{
				if (_slots == null)
				{
					_slots = (CArray<wCHandle<SlotMachineSlot>>) CR2WTypeManager.Create("array:whandle:SlotMachineSlot", "slots", cr2w, this);
				}
				return _slots;
			}
			set
			{
				if (_slots == value)
				{
					return;
				}
				_slots = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("barellAnimation")] 
		public CHandle<inkanimProxy> BarellAnimation
		{
			get
			{
				if (_barellAnimation == null)
				{
					_barellAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "barellAnimation", cr2w, this);
				}
				return _barellAnimation;
			}
			set
			{
				if (_barellAnimation == value)
				{
					return;
				}
				_barellAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("outcomeAnimation")] 
		public CHandle<inkanimProxy> OutcomeAnimation
		{
			get
			{
				if (_outcomeAnimation == null)
				{
					_outcomeAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "outcomeAnimation", cr2w, this);
				}
				return _outcomeAnimation;
			}
			set
			{
				if (_outcomeAnimation == value)
				{
					return;
				}
				_outcomeAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("shouldWinNextTime")] 
		public CBool ShouldWinNextTime
		{
			get
			{
				if (_shouldWinNextTime == null)
				{
					_shouldWinNextTime = (CBool) CR2WTypeManager.Create("Bool", "shouldWinNextTime", cr2w, this);
				}
				return _shouldWinNextTime;
			}
			set
			{
				if (_shouldWinNextTime == value)
				{
					return;
				}
				_shouldWinNextTime = value;
				PropertySet(this);
			}
		}

		public SlotMachineController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
