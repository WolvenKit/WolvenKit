using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderOnEquipmentEffector : gameEffector
	{
		private CArray<wCHandle<gameItemObject>> _items;
		private CArray<CHandle<gameEffectInstance>> _effects;
		private CString _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CHandle<gameEffectInstance> _effectInstance;
		private wCHandle<gameObject> _owner;
		private CHandle<gameEffectInstance> _ownerEffect;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<wCHandle<gameItemObject>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(1)] 
		[RED("effects")] 
		public CArray<CHandle<gameEffectInstance>> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		[Ordinal(2)] 
		[RED("overrideMaterialName")] 
		public CString OverrideMaterialName
		{
			get => GetProperty(ref _overrideMaterialName);
			set => SetProperty(ref _overrideMaterialName, value);
		}

		[Ordinal(3)] 
		[RED("overrideMaterialTag")] 
		public CName OverrideMaterialTag
		{
			get => GetProperty(ref _overrideMaterialTag);
			set => SetProperty(ref _overrideMaterialTag, value);
		}

		[Ordinal(4)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetProperty(ref _effectInstance);
			set => SetProperty(ref _effectInstance, value);
		}

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("ownerEffect")] 
		public CHandle<gameEffectInstance> OwnerEffect
		{
			get => GetProperty(ref _ownerEffect);
			set => SetProperty(ref _ownerEffect, value);
		}

		public ApplyShaderOnEquipmentEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
