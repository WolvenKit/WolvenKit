using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetNPCTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataNPCType> Type
		{
			get => GetPropertyValue<CEnum<gamedataNPCType>>();
			set => SetPropertyValue<CEnum<gamedataNPCType>>(value);
		}
	}
}
