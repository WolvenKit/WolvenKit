using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricBoxControllerPS : MasterControllerPS
	{
		private CHandle<EngineeringContainer> _techieSkillChecks;
		private ComputerQuickHackData _questFactSetup;
		private CBool _isOverriden;

		[Ordinal(104)] 
		[RED("techieSkillChecks")] 
		public CHandle<EngineeringContainer> TechieSkillChecks
		{
			get
			{
				if (_techieSkillChecks == null)
				{
					_techieSkillChecks = (CHandle<EngineeringContainer>) CR2WTypeManager.Create("handle:EngineeringContainer", "techieSkillChecks", cr2w, this);
				}
				return _techieSkillChecks;
			}
			set
			{
				if (_techieSkillChecks == value)
				{
					return;
				}
				_techieSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("questFactSetup")] 
		public ComputerQuickHackData QuestFactSetup
		{
			get
			{
				if (_questFactSetup == null)
				{
					_questFactSetup = (ComputerQuickHackData) CR2WTypeManager.Create("ComputerQuickHackData", "questFactSetup", cr2w, this);
				}
				return _questFactSetup;
			}
			set
			{
				if (_questFactSetup == value)
				{
					return;
				}
				_questFactSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isOverriden")] 
		public CBool IsOverriden
		{
			get
			{
				if (_isOverriden == null)
				{
					_isOverriden = (CBool) CR2WTypeManager.Create("Bool", "isOverriden", cr2w, this);
				}
				return _isOverriden;
			}
			set
			{
				if (_isOverriden == value)
				{
					return;
				}
				_isOverriden = value;
				PropertySet(this);
			}
		}

		public ElectricBoxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
