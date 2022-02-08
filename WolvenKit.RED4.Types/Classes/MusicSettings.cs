using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MusicSettings : IScriptable
	{
		[Ordinal(0)] 
		[RED("statusEffect")] 
		public CEnum<ESoundStatusEffects> StatusEffect
		{
			get => GetPropertyValue<CEnum<ESoundStatusEffects>>();
			set => SetPropertyValue<CEnum<ESoundStatusEffects>>(value);
		}
	}
}
