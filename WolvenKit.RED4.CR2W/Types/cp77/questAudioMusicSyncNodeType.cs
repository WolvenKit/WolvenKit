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
			get
			{
				if (_syncType == null)
				{
					_syncType = (CEnum<audioMusicSyncType>) CR2WTypeManager.Create("audioMusicSyncType", "syncType", cr2w, this);
				}
				return _syncType;
			}
			set
			{
				if (_syncType == value)
				{
					return;
				}
				_syncType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("syncTrack")] 
		public CName SyncTrack
		{
			get
			{
				if (_syncTrack == null)
				{
					_syncTrack = (CName) CR2WTypeManager.Create("CName", "syncTrack", cr2w, this);
				}
				return _syncTrack;
			}
			set
			{
				if (_syncTrack == value)
				{
					return;
				}
				_syncTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("userCue")] 
		public CName UserCue
		{
			get
			{
				if (_userCue == null)
				{
					_userCue = (CName) CR2WTypeManager.Create("CName", "userCue", cr2w, this);
				}
				return _userCue;
			}
			set
			{
				if (_userCue == value)
				{
					return;
				}
				_userCue = value;
				PropertySet(this);
			}
		}

		public questAudioMusicSyncNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
