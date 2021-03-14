using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netInputOrientation : CVariable
	{
		private CFloat _yaw;
		private CFloat _pitch;

		[Ordinal(0)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get
			{
				if (_yaw == null)
				{
					_yaw = (CFloat) CR2WTypeManager.Create("Float", "yaw", cr2w, this);
				}
				return _yaw;
			}
			set
			{
				if (_yaw == value)
				{
					return;
				}
				_yaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get
			{
				if (_pitch == null)
				{
					_pitch = (CFloat) CR2WTypeManager.Create("Float", "pitch", cr2w, this);
				}
				return _pitch;
			}
			set
			{
				if (_pitch == value)
				{
					return;
				}
				_pitch = value;
				PropertySet(this);
			}
		}

		public netInputOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
