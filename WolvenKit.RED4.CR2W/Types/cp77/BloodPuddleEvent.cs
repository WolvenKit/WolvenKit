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
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("cyberBlood")] 
		public CBool CyberBlood
		{
			get => GetProperty(ref _cyberBlood);
			set => SetProperty(ref _cyberBlood, value);
		}

		public BloodPuddleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
