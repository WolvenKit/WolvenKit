using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIScriptActionDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CEnum<AIactionParamsPackageTypes> _actionPackageType;

		[Ordinal(0)] 
		[RED("actionPackageType")] 
		public CEnum<AIactionParamsPackageTypes> ActionPackageType
		{
			get => GetProperty(ref _actionPackageType);
			set => SetProperty(ref _actionPackageType, value);
		}
	}
}
