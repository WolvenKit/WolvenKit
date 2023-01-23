using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyShaderEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("overrideMaterialName")] 
		public CName OverrideMaterialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("overrideMaterialTag")] 
		public CName OverrideMaterialTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("applyToOwner")] 
		public CBool ApplyToOwner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("applyToWeapon")] 
		public CBool ApplyToWeapon
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

		[Ordinal(5)] 
		[RED("ownerWeapons")] 
		public CArray<CWeakHandle<gameItemObject>> OwnerWeapons
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemObject>>>(value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ApplyShaderEffector()
		{
			OwnerWeapons = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
