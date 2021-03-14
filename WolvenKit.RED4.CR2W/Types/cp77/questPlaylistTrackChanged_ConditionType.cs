using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlaylistTrackChanged_ConditionType : questISystemConditionType
	{
		private CName _playlistName;

		[Ordinal(0)] 
		[RED("playlistName")] 
		public CName PlaylistName
		{
			get
			{
				if (_playlistName == null)
				{
					_playlistName = (CName) CR2WTypeManager.Create("CName", "playlistName", cr2w, this);
				}
				return _playlistName;
			}
			set
			{
				if (_playlistName == value)
				{
					return;
				}
				_playlistName = value;
				PropertySet(this);
			}
		}

		public questPlaylistTrackChanged_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
