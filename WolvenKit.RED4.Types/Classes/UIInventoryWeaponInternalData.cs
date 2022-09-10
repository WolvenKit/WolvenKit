using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryWeaponInternalData : IScriptable
	{
		[Ordinal(0)] 
		[RED("ammoFetched")] 
		public CBool AmmoFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("weaponEvolutionFetched")] 
		public CBool WeaponEvolutionFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("damageDataFetched")] 
		public CBool DamageDataFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("WeaponType")] 
		public CEnum<WeaponType> WeaponType
		{
			get => GetPropertyValue<CEnum<WeaponType>>();
			set => SetPropertyValue<CEnum<WeaponType>>(value);
		}

		[Ordinal(4)] 
		[RED("Evolution")] 
		public CEnum<gamedataWeaponEvolution> Evolution
		{
			get => GetPropertyValue<CEnum<gamedataWeaponEvolution>>();
			set => SetPropertyValue<CEnum<gamedataWeaponEvolution>>(value);
		}

		[Ordinal(5)] 
		[RED("EmptySlots")] 
		public CArray<TweakDBID> EmptySlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(6)] 
		[RED("UsedSlots")] 
		public CArray<TweakDBID> UsedSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(7)] 
		[RED("HasSilencerSlot")] 
		public CBool HasSilencerSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("HasScopeSlot")] 
		public CBool HasScopeSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("HasSilencerInstalled")] 
		public CBool HasSilencerInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("HasScopeInstalled")] 
		public CBool HasScopeInstalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("DamageMin")] 
		public CFloat DamageMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("DamageMax")] 
		public CFloat DamageMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("AttackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("NumberOfPellets")] 
		public CInt32 NumberOfPellets
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("Ammo")] 
		public CInt32 Ammo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public UIInventoryWeaponInternalData()
		{
			EmptySlots = new();
			UsedSlots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
