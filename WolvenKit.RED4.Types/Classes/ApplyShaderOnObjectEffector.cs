using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyShaderOnObjectEffector : gameEffector
	{
		private CString _applicationTargetString;
		private CWeakHandle<gameObject> _applicationTarget;
		private CArray<CHandle<gameEffectInstance>> _effects;
		private CName _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CBool _overrideMaterialClearOnDetach;
		private CHandle<gameEffectInstance> _effectInstance;
		private CWeakHandle<gameObject> _owner;
		private CHandle<gameEffectInstance> _ownerEffect;

		[Ordinal(0)] 
		[RED("applicationTargetString")] 
		public CString ApplicationTargetString
		{
			get => GetProperty(ref _applicationTargetString);
			set => SetProperty(ref _applicationTargetString, value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CWeakHandle<gameObject> ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<CHandle<gameEffectInstance>> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		[Ordinal(3)] 
		[RED("overrideMaterialName")] 
		public CName OverrideMaterialName
		{
			get => GetProperty(ref _overrideMaterialName);
			set => SetProperty(ref _overrideMaterialName, value);
		}

		[Ordinal(4)] 
		[RED("overrideMaterialTag")] 
		public CName OverrideMaterialTag
		{
			get => GetProperty(ref _overrideMaterialTag);
			set => SetProperty(ref _overrideMaterialTag, value);
		}

		[Ordinal(5)] 
		[RED("overrideMaterialClearOnDetach")] 
		public CBool OverrideMaterialClearOnDetach
		{
			get => GetProperty(ref _overrideMaterialClearOnDetach);
			set => SetProperty(ref _overrideMaterialClearOnDetach, value);
		}

		[Ordinal(6)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetProperty(ref _effectInstance);
			set => SetProperty(ref _effectInstance, value);
		}

		[Ordinal(7)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(8)] 
		[RED("ownerEffect")] 
		public CHandle<gameEffectInstance> OwnerEffect
		{
			get => GetProperty(ref _ownerEffect);
			set => SetProperty(ref _ownerEffect, value);
		}
	}
}
