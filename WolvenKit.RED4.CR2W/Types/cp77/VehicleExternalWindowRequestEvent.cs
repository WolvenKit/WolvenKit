using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleExternalWindowRequestEvent : redEvent
	{
		private CName _slotName;
		private CBool _shouldOpen;
		private CName _speed;

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
		[RED("shouldOpen")] 
		public CBool ShouldOpen
		{
			get
			{
				if (_shouldOpen == null)
				{
					_shouldOpen = (CBool) CR2WTypeManager.Create("Bool", "shouldOpen", cr2w, this);
				}
				return _shouldOpen;
			}
			set
			{
				if (_shouldOpen == value)
				{
					return;
				}
				_shouldOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CName Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CName) CR2WTypeManager.Create("CName", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		public VehicleExternalWindowRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
