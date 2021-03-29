using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderOnEquipmentEffector : gameEffector
	{
		private CName _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CHandle<gameEffectInstance> _effectInstance;
		private wCHandle<gameObject> _owner;
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
		public wCHandle<gameObject> Owner
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

		public ApplyShaderOnEquipmentEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
