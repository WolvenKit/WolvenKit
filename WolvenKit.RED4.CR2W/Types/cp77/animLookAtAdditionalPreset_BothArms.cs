using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_BothArms : animLookAtAdditionalPreset
	{
		private CBool _rightHanded;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("rightHanded")] 
		public CBool RightHanded
		{
			get
			{
				if (_rightHanded == null)
				{
					_rightHanded = (CBool) CR2WTypeManager.Create("Bool", "rightHanded", cr2w, this);
				}
				return _rightHanded;
			}
			set
			{
				if (_rightHanded == value)
				{
					return;
				}
				_rightHanded = value;
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

		public animLookAtAdditionalPreset_BothArms(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
