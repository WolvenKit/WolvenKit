using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorOpen : ActionBool
	{
		private CName _slotID;
		private CBool _shouldAutoClose;
		private CFloat _autoCloseTime;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (CName) CR2WTypeManager.Create("CName", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("shouldAutoClose")] 
		public CBool ShouldAutoClose
		{
			get
			{
				if (_shouldAutoClose == null)
				{
					_shouldAutoClose = (CBool) CR2WTypeManager.Create("Bool", "shouldAutoClose", cr2w, this);
				}
				return _shouldAutoClose;
			}
			set
			{
				if (_shouldAutoClose == value)
				{
					return;
				}
				_shouldAutoClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("autoCloseTime")] 
		public CFloat AutoCloseTime
		{
			get
			{
				if (_autoCloseTime == null)
				{
					_autoCloseTime = (CFloat) CR2WTypeManager.Create("Float", "autoCloseTime", cr2w, this);
				}
				return _autoCloseTime;
			}
			set
			{
				if (_autoCloseTime == value)
				{
					return;
				}
				_autoCloseTime = value;
				PropertySet(this);
			}
		}

		public VehicleDoorOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
