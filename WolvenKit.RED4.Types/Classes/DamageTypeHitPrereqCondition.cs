using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataDamageType> _damageType;

		[Ordinal(1)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}
	}
}
