using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIStatsScriptConditionType : questIStatsConditionType
	{
		private CHandle<IScriptable> _scriptCondition;

		[Ordinal(0)] 
		[RED("scriptCondition")] 
		public CHandle<IScriptable> ScriptCondition
		{
			get
			{
				if (_scriptCondition == null)
				{
					_scriptCondition = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "scriptCondition", cr2w, this);
				}
				return _scriptCondition;
			}
			set
			{
				if (_scriptCondition == value)
				{
					return;
				}
				_scriptCondition = value;
				PropertySet(this);
			}
		}

		public questIStatsScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
