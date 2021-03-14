using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPlaneUncompressedMotionExtraction : animIMotionExtraction
	{
		private CArray<Vector3> _frames;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<Vector3> Frames
		{
			get
			{
				if (_frames == null)
				{
					_frames = (CArray<Vector3>) CR2WTypeManager.Create("array:Vector3", "frames", cr2w, this);
				}
				return _frames;
			}
			set
			{
				if (_frames == value)
				{
					return;
				}
				_frames = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public animPlaneUncompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
