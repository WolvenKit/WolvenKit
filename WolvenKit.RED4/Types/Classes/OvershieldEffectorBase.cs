using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OvershieldEffectorBase : gameContinuousEffector
	{
		[Ordinal(0)] 
		[RED("statSystem")] 
		public CHandle<gameStatsSystem> StatSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("poolSystem")] 
		public CHandle<gameStatPoolsSystem> PoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(2)] 
		[RED("immunityTypes")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> ImmunityTypes
		{
			get => GetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(3)] 
		[RED("modifiersAdded")] 
		public CBool ModifiersAdded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public OvershieldEffectorBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
