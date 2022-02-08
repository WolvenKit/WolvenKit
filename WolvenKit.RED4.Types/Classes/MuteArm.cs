using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MuteArm : gameweaponObject
	{
		[Ordinal(62)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(63)] 
		[RED("gameEffectInstance")] 
		public CHandle<gameEffectInstance> GameEffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		public MuteArm()
		{
			GameEffectRef = new();
		}
	}
}
