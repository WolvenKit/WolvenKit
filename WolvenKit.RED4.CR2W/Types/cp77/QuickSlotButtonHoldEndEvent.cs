using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotButtonHoldEndEvent : redEvent
	{
		private CEnum<EDPadSlot> _dPadItemDirection;
		private CFloat _rightStickAngle;
		private CBool _tryExecuteCommand;

		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get
			{
				if (_dPadItemDirection == null)
				{
					_dPadItemDirection = (CEnum<EDPadSlot>) CR2WTypeManager.Create("EDPadSlot", "dPadItemDirection", cr2w, this);
				}
				return _dPadItemDirection;
			}
			set
			{
				if (_dPadItemDirection == value)
				{
					return;
				}
				_dPadItemDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rightStickAngle")] 
		public CFloat RightStickAngle
		{
			get
			{
				if (_rightStickAngle == null)
				{
					_rightStickAngle = (CFloat) CR2WTypeManager.Create("Float", "rightStickAngle", cr2w, this);
				}
				return _rightStickAngle;
			}
			set
			{
				if (_rightStickAngle == value)
				{
					return;
				}
				_rightStickAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tryExecuteCommand")] 
		public CBool TryExecuteCommand
		{
			get
			{
				if (_tryExecuteCommand == null)
				{
					_tryExecuteCommand = (CBool) CR2WTypeManager.Create("Bool", "tryExecuteCommand", cr2w, this);
				}
				return _tryExecuteCommand;
			}
			set
			{
				if (_tryExecuteCommand == value)
				{
					return;
				}
				_tryExecuteCommand = value;
				PropertySet(this);
			}
		}

		public QuickSlotButtonHoldEndEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
