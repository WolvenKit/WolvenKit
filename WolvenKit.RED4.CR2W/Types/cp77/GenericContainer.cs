using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericContainer : BaseSkillCheckContainer
	{
		private CHandle<HackingSkillCheck> _hackingCheck;
		private CHandle<EngineeringSkillCheck> _engineeringCheck;
		private CHandle<DemolitionSkillCheck> _demolitionCheck;

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

		[Ordinal(5)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get
			{
				if (_demolitionCheck == null)
				{
					_demolitionCheck = (CHandle<DemolitionSkillCheck>) CR2WTypeManager.Create("handle:DemolitionSkillCheck", "demolitionCheck", cr2w, this);
				}
				return _demolitionCheck;
			}
			set
			{
				if (_demolitionCheck == value)
				{
					return;
				}
				_demolitionCheck = value;
				PropertySet(this);
			}
		}

		public GenericContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
