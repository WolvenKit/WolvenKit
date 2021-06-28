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
			get => GetProperty(ref _playlistName);
			set => SetProperty(ref _playlistName, value);
		}

		public questPlaylistTrackChanged_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
