using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurrentHighLevelNPCStatePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("valueToCheck")] 
		public CEnum<gamedataNPCHighLevelState> ValueToCheck
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
