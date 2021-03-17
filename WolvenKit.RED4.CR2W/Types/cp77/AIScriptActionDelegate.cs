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
			get => GetProperty(ref _actionPackageType);
			set => SetProperty(ref _actionPackageType, value);
		}

		public AIScriptActionDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
