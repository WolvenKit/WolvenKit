using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyShaderOnEquipmentEffector : gameEffector
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
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("ownerEffect")] 
		public CHandle<gameEffectInstance> OwnerEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		public ApplyShaderOnEquipmentEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
