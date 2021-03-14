using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CrowdLocomotion : animAnimFeature
	{
		private CFloat _speed;
		private CFloat _slopeAngle;
		private CBool _isCrowd;

		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slopeAngle")] 
		public CFloat SlopeAngle
		{
			get
			{
				if (_slopeAngle == null)
				{
					_slopeAngle = (CFloat) CR2WTypeManager.Create("Float", "slopeAngle", cr2w, this);
				}
				return _slopeAngle;
			}
			set
			{
				if (_slopeAngle == value)
				{
					return;
				}
				_slopeAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get
			{
				if (_isCrowd == null)
				{
					_isCrowd = (CBool) CR2WTypeManager.Create("Bool", "isCrowd", cr2w, this);
				}
				return _isCrowd;
			}
			set
			{
				if (_isCrowd == value)
				{
					return;
				}
				_isCrowd = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_CrowdLocomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
