using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIScriptActionDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CEnum<AIactionParamsPackageTypes> _actionPackageType;

		[Ordinal(0)] 
		[RED("actionPackageType")] 
		public CEnum<AIactionParamsPackageTypes> ActionPackageType
		{
			get
			{
				if (_actionPackageType == null)
				{
					_actionPackageType = (CEnum<AIactionParamsPackageTypes>) CR2WTypeManager.Create("AIactionParamsPackageTypes", "actionPackageType", cr2w, this);
				}
				return _actionPackageType;
			}
			set
			{
				if (_actionPackageType == value)
				{
					return;
				}
				_actionPackageType = value;
				PropertySet(this);
			}
		}

		public AIScriptActionDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
