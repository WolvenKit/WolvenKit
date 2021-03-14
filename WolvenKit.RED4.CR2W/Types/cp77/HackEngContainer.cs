using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackEngContainer : BaseSkillCheckContainer
	{
		private CHandle<HackingSkillCheck> _hackingCheck;
		private CHandle<EngineeringSkillCheck> _engineeringCheck;

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

		[Ordinal(4)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get
			{
				if (_engineeringCheck == null)
				{
					_engineeringCheck = (CHandle<EngineeringSkillCheck>) CR2WTypeManager.Create("handle:EngineeringSkillCheck", "engineeringCheck", cr2w, this);
				}
				return _engineeringCheck;
			}
			set
			{
				if (_engineeringCheck == value)
				{
					return;
				}
				_engineeringCheck = value;
				PropertySet(this);
			}
		}

		public HackEngContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
