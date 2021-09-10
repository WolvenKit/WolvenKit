using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeUpperBodyState : ChangeUpperBodyStateAbstract
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<gamedataNPCUpperBodyState> NewState
		{
			get => GetPropertyValue<CEnum<gamedataNPCUpperBodyState>>();
			set => SetPropertyValue<CEnum<gamedataNPCUpperBodyState>>(value);
		}
	}
}
