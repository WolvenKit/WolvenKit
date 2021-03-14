using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTracksExtender_ : animAnimNode_OnePoseInput
	{
		private CName _tag;
		private CArray<animFloatTrackInfo> _newTracks;

		[Ordinal(12)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("newTracks")] 
		public CArray<animFloatTrackInfo> NewTracks
		{
			get
			{
				if (_newTracks == null)
				{
					_newTracks = (CArray<animFloatTrackInfo>) CR2WTypeManager.Create("array:animFloatTrackInfo", "newTracks", cr2w, this);
				}
				return _newTracks;
			}
			set
			{
				if (_newTracks == value)
				{
					return;
				}
				_newTracks = value;
				PropertySet(this);
			}
		}

		public animAnimNode_StackTracksExtender_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
