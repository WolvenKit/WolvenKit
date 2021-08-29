using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyShaderOnEquipmentEffector : gameEffector
	{
		private CName _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CHandle<gameEffectInstance> _effectInstance;
		private CWeakHandle<gameObject> _owner;
		private CHandle<gameEffectInstance> _ownerEffect;

		[Ordinal(0)] 
		[RED("overrideMaterialName")] 
		public CName OverrideMaterialName
		{
			get => GetProperty(ref _overrideMaterialName);
			set => SetProperty(ref _overrideMaterialName, value);
		}

		[Ordinal(1)] 
		[RED("overrideMaterialTag")] 
		public CName OverrideMaterialTag
		{
			get => GetProperty(ref _overrideMaterialTag);
			set => SetProperty(ref _overrideMaterialTag, value);
		}

		[Ordinal(2)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetProperty(ref _effectInstance);
			set => SetProperty(ref _effectInstance, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(4)] 
		[RED("ownerEffect")] 
		public CHandle<gameEffectInstance> OwnerEffect
		{
			get => GetProperty(ref _ownerEffect);
			set => SetProperty(ref _ownerEffect, value);
		}
	}
}
