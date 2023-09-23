using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerWeaponHandlingModifiers : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("recoilGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> RecoilGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(1)] 
		[RED("timeOutGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> TimeOutGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(2)] 
		[RED("multSwayGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> MultSwayGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(3)] 
		[RED("addSwayGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> AddSwayGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(4)] 
		[RED("spreadGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> SpreadGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		public PlayerWeaponHandlingModifiers()
		{
			RecoilGroup = new();
			TimeOutGroup = new();
			MultSwayGroup = new();
			AddSwayGroup = new();
			SpreadGroup = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
