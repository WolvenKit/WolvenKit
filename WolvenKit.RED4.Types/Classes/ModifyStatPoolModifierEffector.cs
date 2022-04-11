using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyStatPoolModifierEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("poolModifier")] 
		public gameStatPoolModifier PoolModifier
		{
			get => GetPropertyValue<gameStatPoolModifier>();
			set => SetPropertyValue<gameStatPoolModifier>(value);
		}

		[Ordinal(3)] 
		[RED("poolType")] 
		public CEnum<gamedataStatPoolType> PoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(4)] 
		[RED("modType")] 
		public CEnum<gameStatPoolModificationTypes> ModType
		{
			get => GetPropertyValue<CEnum<gameStatPoolModificationTypes>>();
			set => SetPropertyValue<CEnum<gameStatPoolModificationTypes>>(value);
		}

		[Ordinal(5)] 
		[RED("previousMod")] 
		public gameStatPoolModifier PreviousMod
		{
			get => GetPropertyValue<gameStatPoolModifier>();
			set => SetPropertyValue<gameStatPoolModifier>(value);
		}

		public ModifyStatPoolModifierEffector()
		{
			OwnerEntityID = new();
			PoolModifier = new();
			PreviousMod = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
