using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_EyesHeadWithoutSuppress : animLookAtPreset
	{
		private CFloat _headMobility;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("headMobility")] 
		public CFloat HeadMobility
		{
			get
			{
				if (_headMobility == null)
				{
					_headMobility = (CFloat) CR2WTypeManager.Create("Float", "headMobility", cr2w, this);
				}
				return _headMobility;
			}
			set
			{
				if (_headMobility == value)
				{
					return;
				}
				_headMobility = value;
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

		public animLookAtPreset_EyesHeadWithoutSuppress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
