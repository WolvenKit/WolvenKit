using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseSkillCheckContainer : IScriptable
	{
		private CHandle<HackingSkillCheck> _hackingCheckSlot;
		private CHandle<EngineeringSkillCheck> _engineeringCheckSlot;
		private CHandle<DemolitionSkillCheck> _demolitionCheckSlot;

		[Ordinal(0)] 
		[RED("hackingCheckSlot")] 
		public CHandle<HackingSkillCheck> HackingCheckSlot
		{
			get
			{
				if (_hackingCheckSlot == null)
				{
					_hackingCheckSlot = (CHandle<HackingSkillCheck>) CR2WTypeManager.Create("handle:HackingSkillCheck", "hackingCheckSlot", cr2w, this);
				}
				return _hackingCheckSlot;
			}
			set
			{
				if (_hackingCheckSlot == value)
				{
					return;
				}
				_hackingCheckSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("engineeringCheckSlot")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheckSlot
		{
			get
			{
				if (_engineeringCheckSlot == null)
				{
					_engineeringCheckSlot = (CHandle<EngineeringSkillCheck>) CR2WTypeManager.Create("handle:EngineeringSkillCheck", "engineeringCheckSlot", cr2w, this);
				}
				return _engineeringCheckSlot;
			}
			set
			{
				if (_engineeringCheckSlot == value)
				{
					return;
				}
				_engineeringCheckSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("demolitionCheckSlot")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheckSlot
		{
			get
			{
				if (_demolitionCheckSlot == null)
				{
					_demolitionCheckSlot = (CHandle<DemolitionSkillCheck>) CR2WTypeManager.Create("handle:DemolitionSkillCheck", "demolitionCheckSlot", cr2w, this);
				}
				return _demolitionCheckSlot;
			}
			set
			{
				if (_demolitionCheckSlot == value)
				{
					return;
				}
				_demolitionCheckSlot = value;
				PropertySet(this);
			}
		}

		public BaseSkillCheckContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
