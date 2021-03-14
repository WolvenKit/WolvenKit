using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCAnimationBufferUncompressed : animIAnimationBuffer
	{
		private CArray<CArray<QsTransform>> _transforms;
		private CArray<CArray<CFloat>> _tracks;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<CArray<QsTransform>> Transforms
		{
			get
			{
				if (_transforms == null)
				{
					_transforms = (CArray<CArray<QsTransform>>) CR2WTypeManager.Create("array:array:QsTransform", "transforms", cr2w, this);
				}
				return _transforms;
			}
			set
			{
				if (_transforms == value)
				{
					return;
				}
				_transforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tracks")] 
		public CArray<CArray<CFloat>> Tracks
		{
			get
			{
				if (_tracks == null)
				{
					_tracks = (CArray<CArray<CFloat>>) CR2WTypeManager.Create("array:array:Float", "tracks", cr2w, this);
				}
				return _tracks;
			}
			set
			{
				if (_tracks == value)
				{
					return;
				}
				_tracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public animCAnimationBufferUncompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
