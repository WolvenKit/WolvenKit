using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveAllStatusEffectOfTypeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("statusEffectType")] 
		public CEnum<gamedataStatusEffectType> StatusEffectType
		{
			get => GetPropertyValue<CEnum<gamedataStatusEffectType>>();
			set => SetPropertyValue<CEnum<gamedataStatusEffectType>>(value);
		}
	}
}
