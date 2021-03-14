using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMarketingAnimationComponent : entIPlacedComponent
	{
		private CBool _freezeAnimations;
		private CArray<entMarketingAnimationEntry> _animations;
		private CBool _enableLookAt;
		private CHandle<animLookAtPreset_FullControl> _lookAtSettings;
		private CFloat _lookAtOrbitDistance;
		private CFloat _lookAtTargetPitch;
		private CFloat _lookAtTargetYaw;

		[Ordinal(5)] 
		[RED("freezeAnimations")] 
		public CBool FreezeAnimations
		{
			get
			{
				if (_freezeAnimations == null)
				{
					_freezeAnimations = (CBool) CR2WTypeManager.Create("Bool", "freezeAnimations", cr2w, this);
				}
				return _freezeAnimations;
			}
			set
			{
				if (_freezeAnimations == value)
				{
					return;
				}
				_freezeAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("animations")] 
		public CArray<entMarketingAnimationEntry> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<entMarketingAnimationEntry>) CR2WTypeManager.Create("array:entMarketingAnimationEntry", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("enableLookAt")] 
		public CBool EnableLookAt
		{
			get
			{
				if (_enableLookAt == null)
				{
					_enableLookAt = (CBool) CR2WTypeManager.Create("Bool", "enableLookAt", cr2w, this);
				}
				return _enableLookAt;
			}
			set
			{
				if (_enableLookAt == value)
				{
					return;
				}
				_enableLookAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lookAtSettings")] 
		public CHandle<animLookAtPreset_FullControl> LookAtSettings
		{
			get
			{
				if (_lookAtSettings == null)
				{
					_lookAtSettings = (CHandle<animLookAtPreset_FullControl>) CR2WTypeManager.Create("handle:animLookAtPreset_FullControl", "lookAtSettings", cr2w, this);
				}
				return _lookAtSettings;
			}
			set
			{
				if (_lookAtSettings == value)
				{
					return;
				}
				_lookAtSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lookAtOrbitDistance")] 
		public CFloat LookAtOrbitDistance
		{
			get
			{
				if (_lookAtOrbitDistance == null)
				{
					_lookAtOrbitDistance = (CFloat) CR2WTypeManager.Create("Float", "lookAtOrbitDistance", cr2w, this);
				}
				return _lookAtOrbitDistance;
			}
			set
			{
				if (_lookAtOrbitDistance == value)
				{
					return;
				}
				_lookAtOrbitDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lookAtTargetPitch")] 
		public CFloat LookAtTargetPitch
		{
			get
			{
				if (_lookAtTargetPitch == null)
				{
					_lookAtTargetPitch = (CFloat) CR2WTypeManager.Create("Float", "lookAtTargetPitch", cr2w, this);
				}
				return _lookAtTargetPitch;
			}
			set
			{
				if (_lookAtTargetPitch == value)
				{
					return;
				}
				_lookAtTargetPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("lookAtTargetYaw")] 
		public CFloat LookAtTargetYaw
		{
			get
			{
				if (_lookAtTargetYaw == null)
				{
					_lookAtTargetYaw = (CFloat) CR2WTypeManager.Create("Float", "lookAtTargetYaw", cr2w, this);
				}
				return _lookAtTargetYaw;
			}
			set
			{
				if (_lookAtTargetYaw == value)
				{
					return;
				}
				_lookAtTargetYaw = value;
				PropertySet(this);
			}
		}

		public entMarketingAnimationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
