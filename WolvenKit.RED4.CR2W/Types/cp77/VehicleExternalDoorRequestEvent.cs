using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleExternalDoorRequestEvent : redEvent
	{
		private CName _slotName;
		private CBool _autoClose;
		private CFloat _autoCloseTime;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("autoClose")] 
		public CBool AutoClose
		{
			get
			{
				if (_autoClose == null)
				{
					_autoClose = (CBool) CR2WTypeManager.Create("Bool", "autoClose", cr2w, this);
				}
				return _autoClose;
			}
			set
			{
				if (_autoClose == value)
				{
					return;
				}
				_autoClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public VehicleExternalDoorRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
