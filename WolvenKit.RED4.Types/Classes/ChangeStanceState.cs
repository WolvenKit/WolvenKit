using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeStanceState : ChangeStanceStateAbstract
	{
		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<gamedataNPCStanceState> NewState
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}
	}
}
