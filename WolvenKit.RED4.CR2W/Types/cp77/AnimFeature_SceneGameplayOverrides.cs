using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SceneGameplayOverrides : animAnimFeature
	{
		private CBool _aimForced;
		private CBool _safeForced;
		private CBool _isAimOutTimeOverridden;
		private CFloat _aimOutTimeOverride;

		[Ordinal(0)] 
		[RED("aimForced")] 
		public CBool AimForced
		{
			get
			{
				if (_aimForced == null)
				{
					_aimForced = (CBool) CR2WTypeManager.Create("Bool", "aimForced", cr2w, this);
				}
				return _aimForced;
			}
			set
			{
				if (_aimForced == value)
				{
					return;
				}
				_aimForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("safeForced")] 
		public CBool SafeForced
		{
			get
			{
				if (_safeForced == null)
				{
					_safeForced = (CBool) CR2WTypeManager.Create("Bool", "safeForced", cr2w, this);
				}
				return _safeForced;
			}
			set
			{
				if (_safeForced == value)
				{
					return;
				}
				_safeForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isAimOutTimeOverridden")] 
		public CBool IsAimOutTimeOverridden
		{
			get
			{
				if (_isAimOutTimeOverridden == null)
				{
					_isAimOutTimeOverridden = (CBool) CR2WTypeManager.Create("Bool", "isAimOutTimeOverridden", cr2w, this);
				}
				return _isAimOutTimeOverridden;
			}
			set
			{
				if (_isAimOutTimeOverridden == value)
				{
					return;
				}
				_isAimOutTimeOverridden = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("aimOutTimeOverride")] 
		public CFloat AimOutTimeOverride
		{
			get
			{
				if (_aimOutTimeOverride == null)
				{
					_aimOutTimeOverride = (CFloat) CR2WTypeManager.Create("Float", "aimOutTimeOverride", cr2w, this);
				}
				return _aimOutTimeOverride;
			}
			set
			{
				if (_aimOutTimeOverride == value)
				{
					return;
				}
				_aimOutTimeOverride = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SceneGameplayOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
