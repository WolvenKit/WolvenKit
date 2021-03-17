using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackingContainer : BaseSkillCheckContainer
	{
		private CHandle<HackingSkillCheck> _hackingCheck;

		[Ordinal(3)] 
		[RED("hackingCheck")] 
		public CHandle<HackingSkillCheck> HackingCheck
		{
			get => GetProperty(ref _hackingCheck);
			set => SetProperty(ref _hackingCheck, value);
		}

		public HackingContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
