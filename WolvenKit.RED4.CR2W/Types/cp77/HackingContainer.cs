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
			get
			{
				if (_hackingCheck == null)
				{
					_hackingCheck = (CHandle<HackingSkillCheck>) CR2WTypeManager.Create("handle:HackingSkillCheck", "hackingCheck", cr2w, this);
				}
				return _hackingCheck;
			}
			set
			{
				if (_hackingCheck == value)
				{
					return;
				}
				_hackingCheck = value;
				PropertySet(this);
			}
		}

		public HackingContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
