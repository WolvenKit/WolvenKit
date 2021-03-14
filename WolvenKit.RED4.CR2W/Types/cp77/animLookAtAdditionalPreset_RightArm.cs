using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_RightArm : animLookAtAdditionalPreset
	{
		private CBool _isAiming;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get
			{
				if (_isAiming == null)
				{
					_isAiming = (CBool) CR2WTypeManager.Create("Bool", "isAiming", cr2w, this);
				}
				return _isAiming;
			}
			set
			{
				if (_isAiming == value)
				{
					return;
				}
				_isAiming = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get
			{
				if (_softLimitAngle == null)
				{
					_softLimitAngle = (CFloat) CR2WTypeManager.Create("Float", "softLimitAngle", cr2w, this);
				}
				return _softLimitAngle;
			}
			set
			{
				if (_softLimitAngle == value)
				{
					return;
				}
				_softLimitAngle = value;
				PropertySet(this);
			}
		}

		public animLookAtAdditionalPreset_RightArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
