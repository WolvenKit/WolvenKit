using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PersonnelSystem : DeviceSystemBase
	{
		private CBool _enableE3QuickHacks;

		[Ordinal(96)] 
		[RED("EnableE3QuickHacks")] 
		public CBool EnableE3QuickHacks
		{
			get => GetProperty(ref _enableE3QuickHacks);
			set => SetProperty(ref _enableE3QuickHacks, value);
		}

		public PersonnelSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
