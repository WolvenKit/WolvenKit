using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveAllStatusEffectOfTypeEvent : redEvent
	{
		private CEnum<gamedataStatusEffectType> _statusEffectType;

		[Ordinal(0)] 
		[RED("statusEffectType")] 
		public CEnum<gamedataStatusEffectType> StatusEffectType
		{
			get => GetProperty(ref _statusEffectType);
			set => SetProperty(ref _statusEffectType, value);
		}
	}
}
