using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurrentStanceNPCStatePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("valueToCheck")] 
		public CEnum<gamedataNPCStanceState> ValueToCheck
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
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
