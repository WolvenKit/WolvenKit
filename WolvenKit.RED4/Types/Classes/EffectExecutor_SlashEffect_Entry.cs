using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_SlashEffect_Entry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("attackNumber")] 
		public CInt32 AttackNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("effectNames")] 
		public CArray<CName> EffectNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public EffectExecutor_SlashEffect_Entry()
		{
			EffectNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
