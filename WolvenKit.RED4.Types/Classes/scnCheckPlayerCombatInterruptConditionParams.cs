using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckPlayerCombatInterruptConditionParams : RedBaseClass
	{
		private CBool _isInCombat;

		[Ordinal(0)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetProperty(ref _isInCombat);
			set => SetProperty(ref _isInCombat, value);
		}

		public scnCheckPlayerCombatInterruptConditionParams()
		{
			_isInCombat = true;
		}
	}
}
