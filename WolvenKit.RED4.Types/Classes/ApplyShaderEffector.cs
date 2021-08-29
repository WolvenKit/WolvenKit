using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyShaderEffector : gameEffector
	{
		private CName _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CBool _applyToOwner;
		private CBool _applyToWeapon;
		private CWeakHandle<gameObject> _owner;
		private CArray<CWeakHandle<gameItemObject>> _ownerWeapons;
		private CBool _isEnabled;

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
		[RED("applyToOwner")] 
		public CBool ApplyToOwner
		{
			get => GetProperty(ref _applyToOwner);
			set => SetProperty(ref _applyToOwner, value);
		}

		[Ordinal(3)] 
		[RED("applyToWeapon")] 
		public CBool ApplyToWeapon
		{
			get => GetProperty(ref _applyToWeapon);
			set => SetProperty(ref _applyToWeapon, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(5)] 
		[RED("ownerWeapons")] 
		public CArray<CWeakHandle<gameItemObject>> OwnerWeapons
		{
			get => GetProperty(ref _ownerWeapons);
			set => SetProperty(ref _ownerWeapons, value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
