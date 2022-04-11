using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddHitFlagToAttackEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get => GetPropertyValue<CEnum<hitFlag>>();
			set => SetPropertyValue<CEnum<hitFlag>>(value);
		}
	}
}
