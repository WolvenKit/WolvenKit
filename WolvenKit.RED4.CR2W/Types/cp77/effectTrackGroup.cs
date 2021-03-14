using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackGroup : effectTrackBase
	{
		private CArray<CHandle<effectTrackBase>> _tracks;
		private CName _componentName;

		[Ordinal(0)] 
		[RED("tracks")] 
		public CArray<CHandle<effectTrackBase>> Tracks
		{
			get
			{
				if (_tracks == null)
				{
					_tracks = (CArray<CHandle<effectTrackBase>>) CR2WTypeManager.Create("array:handle:effectTrackBase", "tracks", cr2w, this);
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

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		public effectTrackGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
