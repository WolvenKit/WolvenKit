using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurrentStanceNPCStatePrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataNPCStanceState> _valueToCheck;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("valueToCheck")] 
		public CEnum<gamedataNPCStanceState> ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}
	}
}
