using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyShaderOnObjectEffector : gameEffector
	{
		private CString _applicationTargetString;
		private wCHandle<gameObject> _applicationTarget;
		private CArray<CHandle<gameEffectInstance>> _effects;
		private CString _overrideMaterialName;
		private CName _overrideMaterialTag;
		private CHandle<gameEffectInstance> _effectInstance;
		private wCHandle<gameObject> _owner;
		private CHandle<gameEffectInstance> _ownerEffect;

		[Ordinal(0)] 
		[RED("applicationTargetString")] 
		public CString ApplicationTargetString
		{
			get
			{
				if (_applicationTargetString == null)
				{
					_applicationTargetString = (CString) CR2WTypeManager.Create("String", "applicationTargetString", cr2w, this);
				}
				return _applicationTargetString;
			}
			set
			{
				if (_applicationTargetString == value)
				{
					return;
				}
				_applicationTargetString = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public wCHandle<gameObject> ApplicationTarget
		{
			get
			{
				if (_applicationTarget == null)
				{
					_applicationTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "applicationTarget", cr2w, this);
				}
				return _applicationTarget;
			}
			set
			{
				if (_applicationTarget == value)
				{
					return;
				}
				_applicationTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<CHandle<gameEffectInstance>> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<CHandle<gameEffectInstance>>) CR2WTypeManager.Create("array:handle:gameEffectInstance", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("overrideMaterialName")] 
		public CString OverrideMaterialName
		{
			get
			{
				if (_overrideMaterialName == null)
				{
					_overrideMaterialName = (CString) CR2WTypeManager.Create("String", "overrideMaterialName", cr2w, this);
				}
				return _overrideMaterialName;
			}
			set
			{
				if (_overrideMaterialName == value)
				{
					return;
				}
				_overrideMaterialName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("overrideMaterialTag")] 
		public CName OverrideMaterialTag
		{
			get
			{
				if (_overrideMaterialTag == null)
				{
					_overrideMaterialTag = (CName) CR2WTypeManager.Create("CName", "overrideMaterialTag", cr2w, this);
				}
				return _overrideMaterialTag;
			}
			set
			{
				if (_overrideMaterialTag == value)
				{
					return;
				}
				_overrideMaterialTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get
			{
				if (_effectInstance == null)
				{
					_effectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "effectInstance", cr2w, this);
				}
				return _effectInstance;
			}
			set
			{
				if (_effectInstance == value)
				{
					return;
				}
				_effectInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ownerEffect")] 
		public CHandle<gameEffectInstance> OwnerEffect
		{
			get
			{
				if (_ownerEffect == null)
				{
					_ownerEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "ownerEffect", cr2w, this);
				}
				return _ownerEffect;
			}
			set
			{
				if (_ownerEffect == value)
				{
					return;
				}
				_ownerEffect = value;
				PropertySet(this);
			}
		}

		public ApplyShaderOnObjectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
