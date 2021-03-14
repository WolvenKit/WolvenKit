using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TrackSetter : animAnimNode_OnePoseInput
	{
		private animNamedTrackIndex _track;
		private animFloatLink _value;

		[Ordinal(12)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get
			{
				if (_track == null)
				{
					_track = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "track", cr2w, this);
				}
				return _track;
			}
			set
			{
				if (_track == value)
				{
					return;
				}
				_track = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("value")] 
		public animFloatLink Value
		{
			get
			{
				if (_value == null)
				{
					_value = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public animAnimNode_TrackSetter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
