using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MusicSettings : IScriptable
	{
		private CEnum<ESoundStatusEffects> _statusEffect;

		[Ordinal(0)] 
		[RED("statusEffect")] 
		public CEnum<ESoundStatusEffects> StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}
	}
}
