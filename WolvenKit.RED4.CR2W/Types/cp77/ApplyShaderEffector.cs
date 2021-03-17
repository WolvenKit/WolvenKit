using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderEffector : gameEffector
	{
		private CName _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CBool _applyToOwner;
		private CBool _applyToWeapon;
		private wCHandle<gameObject> _owner;
		private CArray<wCHandle<gameItemObject>> _ownerWeapons;
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
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(5)] 
		[RED("ownerWeapons")] 
		public CArray<wCHandle<gameItemObject>> OwnerWeapons
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

		public ApplyShaderEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
