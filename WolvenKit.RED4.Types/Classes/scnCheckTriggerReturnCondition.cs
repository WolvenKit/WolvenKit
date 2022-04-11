using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckTriggerReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckTriggerReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckTriggerReturnConditionParams>();
			set => SetPropertyValue<scnCheckTriggerReturnConditionParams>(value);
		}

		public scnCheckTriggerReturnCondition()
		{
			Params = new() { Inside = true };
		}
	}
}
