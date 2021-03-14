using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_EyesHead : animLookAtPreset
	{
		private CFloat _suppressHeadAnimation;
		private CFloat _headMobility;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("suppressHeadAnimation")] 
		public CFloat SuppressHeadAnimation
		{
			get
			{
				if (_suppressHeadAnimation == null)
				{
					_suppressHeadAnimation = (CFloat) CR2WTypeManager.Create("Float", "suppressHeadAnimation", cr2w, this);
				}
				return _suppressHeadAnimation;
			}
			set
			{
				if (_suppressHeadAnimation == value)
				{
					return;
				}
				_suppressHeadAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public animLookAtPreset_EyesHead(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
