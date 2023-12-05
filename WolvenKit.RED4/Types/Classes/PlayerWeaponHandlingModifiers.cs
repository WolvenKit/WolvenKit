using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerWeaponHandlingModifiers : IScriptable
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("opSymbol")] 
		public CName OpSymbol
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("recoilGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> RecoilGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(3)] 
		[RED("timeOutGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> TimeOutGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(4)] 
		[RED("multSwayGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> MultSwayGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(5)] 
		[RED("addSwayGroup")] 
		public CArray<CHandle<gameConstantStatModifierData_Deprecated>> AddSwayGroup
		{
			get => GetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameConstantStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(6)] 
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
