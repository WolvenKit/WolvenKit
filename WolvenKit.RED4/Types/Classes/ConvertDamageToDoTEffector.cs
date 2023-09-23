using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConvertDamageToDoTEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("DamageToDoTConversion")] 
		public CFloat DamageToDoTConversion
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("DotDistributionTime")] 
		public CFloat DotDistributionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("statMod")] 
		public CHandle<gameConstantStatModifierData_Deprecated> StatMod
		{
			get => GetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameConstantStatModifierData_Deprecated>>(value);
		}

		[Ordinal(3)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ConvertDamageToDoTEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
