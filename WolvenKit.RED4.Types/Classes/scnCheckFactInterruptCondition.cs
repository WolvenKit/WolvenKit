using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckFactInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckFactInterruptConditionParams Params
		{
			get => GetPropertyValue<scnCheckFactInterruptConditionParams>();
			set => SetPropertyValue<scnCheckFactInterruptConditionParams>(value);
		}

		public scnCheckFactInterruptCondition()
		{
			Params = new();
		}
	}
}
