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
		[RED("poolType")] 
		public CEnum<gamedataStatPoolType> PoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(3)] 
		[RED("modType")] 
		public CEnum<gameStatPoolModificationTypes> ModType
		{
			get => GetPropertyValue<CEnum<gameStatPoolModificationTypes>>();
			set => SetPropertyValue<CEnum<gameStatPoolModificationTypes>>(value);
		}

		[Ordinal(4)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("cachedModifier")] 
		public gameStatPoolModifier CachedModifier
		{
			get => GetPropertyValue<gameStatPoolModifier>();
			set => SetPropertyValue<gameStatPoolModifier>(value);
		}

		public ModifyStatPoolModifierEffector()
		{
			OwnerEntityID = new entEntityID();
			CachedModifier = new gameStatPoolModifier();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
