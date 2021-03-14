using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomValueFromMappingTimeout : AITimeoutCondition
	{
		private CHandle<AIArgumentMapping> _actionTweakIDMapping;

		[Ordinal(1)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get
			{
				if (_actionTweakIDMapping == null)
				{
					_actionTweakIDMapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "actionTweakIDMapping", cr2w, this);
				}
				return _actionTweakIDMapping;
			}
			set
			{
				if (_actionTweakIDMapping == value)
				{
					return;
				}
				_actionTweakIDMapping = value;
				PropertySet(this);
			}
		}

		public CustomValueFromMappingTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
