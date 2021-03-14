using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BloodPuddleEvent : redEvent
	{
		private CName _slotName;
		private CBool _cyberBlood;

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
		[RED("cyberBlood")] 
		public CBool CyberBlood
		{
			get
			{
				if (_cyberBlood == null)
				{
					_cyberBlood = (CBool) CR2WTypeManager.Create("Bool", "cyberBlood", cr2w, this);
				}
				return _cyberBlood;
			}
			set
			{
				if (_cyberBlood == value)
				{
					return;
				}
				_cyberBlood = value;
				PropertySet(this);
			}
		}

		public BloodPuddleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
