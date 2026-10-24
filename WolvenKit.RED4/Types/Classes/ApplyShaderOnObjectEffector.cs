using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyShaderOnObjectEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("applicationTargetName")] 
		public CName ApplicationTargetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("applicationTargets")] 
		public CArray<CWeakHandle<gameObject>> ApplicationTargets
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<CHandle<gameEffectInstance>> Effects
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectInstance>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectInstance>>>(value);
		}

		[Ordinal(3)] 
		[RED("overrideMaterialName")] 
		public CName OverrideMaterialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("overrideMaterialTag")] 
		public CName OverrideMaterialTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("overrideMaterialClearOnDetach")] 
		public CBool OverrideMaterialClearOnDetach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(7)] 
		[RED("ownerEffect")] 
		public CHandle<gameEffectInstance> OwnerEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		public ApplyShaderOnObjectEffector()
		{
			ApplicationTargets = new();
			Effects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
