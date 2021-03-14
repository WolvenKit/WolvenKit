using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLoggerEntry_FloatTrack : animPoseInfoLoggerEntry
	{
		private animNamedTrackIndex _floatTrack;
		private CBool _showOnlyWhenPositive;

		[Ordinal(0)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get
			{
				if (_floatTrack == null)
				{
					_floatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "floatTrack", cr2w, this);
				}
				return _floatTrack;
			}
			set
			{
				if (_floatTrack == value)
				{
					return;
				}
				_floatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("showOnlyWhenPositive")] 
		public CBool ShowOnlyWhenPositive
		{
			get
			{
				if (_showOnlyWhenPositive == null)
				{
					_showOnlyWhenPositive = (CBool) CR2WTypeManager.Create("Bool", "showOnlyWhenPositive", cr2w, this);
				}
				return _showOnlyWhenPositive;
			}
			set
			{
				if (_showOnlyWhenPositive == value)
				{
					return;
				}
				_showOnlyWhenPositive = value;
				PropertySet(this);
			}
		}

		public animPoseInfoLoggerEntry_FloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
