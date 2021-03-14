using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetSkillcheckEvent : redEvent
	{
		private CHandle<BaseSkillCheckContainer> _skillcheckContainer;

		[Ordinal(0)] 
		[RED("skillcheckContainer")] 
		public CHandle<BaseSkillCheckContainer> SkillcheckContainer
		{
			get
			{
				if (_skillcheckContainer == null)
				{
					_skillcheckContainer = (CHandle<BaseSkillCheckContainer>) CR2WTypeManager.Create("handle:BaseSkillCheckContainer", "skillcheckContainer", cr2w, this);
				}
				return _skillcheckContainer;
			}
			set
			{
				if (_skillcheckContainer == value)
				{
					return;
				}
				_skillcheckContainer = value;
				PropertySet(this);
			}
		}

		public SetSkillcheckEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
