using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraBreathing : animAnimFeature
	{
		private CFloat _amplitudeWeight;
		private CFloat _dampIncreaseSpeed;
		private CFloat _dampDecreaseSpeed;

		[Ordinal(0)] 
		[RED("amplitudeWeight")] 
		public CFloat AmplitudeWeight
		{
			get
			{
				if (_amplitudeWeight == null)
				{
					_amplitudeWeight = (CFloat) CR2WTypeManager.Create("Float", "amplitudeWeight", cr2w, this);
				}
				return _amplitudeWeight;
			}
			set
			{
				if (_amplitudeWeight == value)
				{
					return;
				}
				_amplitudeWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dampIncreaseSpeed")] 
		public CFloat DampIncreaseSpeed
		{
			get
			{
				if (_dampIncreaseSpeed == null)
				{
					_dampIncreaseSpeed = (CFloat) CR2WTypeManager.Create("Float", "dampIncreaseSpeed", cr2w, this);
				}
				return _dampIncreaseSpeed;
			}
			set
			{
				if (_dampIncreaseSpeed == value)
				{
					return;
				}
				_dampIncreaseSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dampDecreaseSpeed")] 
		public CFloat DampDecreaseSpeed
		{
			get
			{
				if (_dampDecreaseSpeed == null)
				{
					_dampDecreaseSpeed = (CFloat) CR2WTypeManager.Create("Float", "dampDecreaseSpeed", cr2w, this);
				}
				return _dampDecreaseSpeed;
			}
			set
			{
				if (_dampDecreaseSpeed == value)
				{
					return;
				}
				_dampDecreaseSpeed = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CameraBreathing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
