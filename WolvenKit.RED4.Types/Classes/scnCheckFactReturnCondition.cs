using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckFactReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckFactReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckFactReturnConditionParams>();
			set => SetPropertyValue<scnCheckFactReturnConditionParams>(value);
		}

		public scnCheckFactReturnCondition()
		{
			Params = new();
		}
	}
}
