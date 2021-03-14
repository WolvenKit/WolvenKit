using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyclableRadialSlot : WeaponRadialSlot
	{
		private inkWidgetReference _leftArrowEmpty;
		private inkWidgetReference _leftArrowFull;
		private inkWidgetReference _rightArrowEmpty;
		private inkWidgetReference _rightArrowFull;
		private CBool _canCycle;
		private CBool _isCycling;
		private CBool _wasCyclingRight;
		private CEnum<gameEHotkey> _hotkey;

		[Ordinal(11)] 
		[RED("leftArrowEmpty")] 
		public inkWidgetReference LeftArrowEmpty
		{
			get
			{
				if (_leftArrowEmpty == null)
				{
					_leftArrowEmpty = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftArrowEmpty", cr2w, this);
				}
				return _leftArrowEmpty;
			}
			set
			{
				if (_leftArrowEmpty == value)
				{
					return;
				}
				_leftArrowEmpty = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("leftArrowFull")] 
		public inkWidgetReference LeftArrowFull
		{
			get
			{
				if (_leftArrowFull == null)
				{
					_leftArrowFull = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftArrowFull", cr2w, this);
				}
				return _leftArrowFull;
			}
			set
			{
				if (_leftArrowFull == value)
				{
					return;
				}
				_leftArrowFull = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rightArrowEmpty")] 
		public inkWidgetReference RightArrowEmpty
		{
			get
			{
				if (_rightArrowEmpty == null)
				{
					_rightArrowEmpty = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightArrowEmpty", cr2w, this);
				}
				return _rightArrowEmpty;
			}
			set
			{
				if (_rightArrowEmpty == value)
				{
					return;
				}
				_rightArrowEmpty = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rightArrowFull")] 
		public inkWidgetReference RightArrowFull
		{
			get
			{
				if (_rightArrowFull == null)
				{
					_rightArrowFull = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightArrowFull", cr2w, this);
				}
				return _rightArrowFull;
			}
			set
			{
				if (_rightArrowFull == value)
				{
					return;
				}
				_rightArrowFull = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("canCycle")] 
		public CBool CanCycle
		{
			get
			{
				if (_canCycle == null)
				{
					_canCycle = (CBool) CR2WTypeManager.Create("Bool", "canCycle", cr2w, this);
				}
				return _canCycle;
			}
			set
			{
				if (_canCycle == value)
				{
					return;
				}
				_canCycle = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isCycling")] 
		public CBool IsCycling
		{
			get
			{
				if (_isCycling == null)
				{
					_isCycling = (CBool) CR2WTypeManager.Create("Bool", "isCycling", cr2w, this);
				}
				return _isCycling;
			}
			set
			{
				if (_isCycling == value)
				{
					return;
				}
				_isCycling = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("wasCyclingRight")] 
		public CBool WasCyclingRight
		{
			get
			{
				if (_wasCyclingRight == null)
				{
					_wasCyclingRight = (CBool) CR2WTypeManager.Create("Bool", "wasCyclingRight", cr2w, this);
				}
				return _wasCyclingRight;
			}
			set
			{
				if (_wasCyclingRight == value)
				{
					return;
				}
				_wasCyclingRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get
			{
				if (_hotkey == null)
				{
					_hotkey = (CEnum<gameEHotkey>) CR2WTypeManager.Create("gameEHotkey", "hotkey", cr2w, this);
				}
				return _hotkey;
			}
			set
			{
				if (_hotkey == value)
				{
					return;
				}
				_hotkey = value;
				PropertySet(this);
			}
		}

		public CyclableRadialSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
