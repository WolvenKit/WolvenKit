using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioMusicSyncNodeType : questIAudioNodeType
	{
		private CEnum<audioMusicSyncType> _syncType;
		private CString _description;
		private CName _syncTrack;
		private CName _userCue;

		[Ordinal(0)] 
		[RED("syncType")] 
		public CEnum<audioMusicSyncType> SyncType
		{
			get => GetProperty(ref _syncType);
			set => SetProperty(ref _syncType, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("syncTrack")] 
		public CName SyncTrack
		{
			get => GetProperty(ref _syncTrack);
			set => SetProperty(ref _syncTrack, value);
		}

		[Ordinal(3)] 
		[RED("userCue")] 
		public CName UserCue
		{
			get => GetProperty(ref _userCue);
			set => SetProperty(ref _userCue, value);
		}

		public questAudioMusicSyncNodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
