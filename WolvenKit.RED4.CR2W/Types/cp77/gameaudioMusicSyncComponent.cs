using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioMusicSyncComponent : entIComponent
	{
		private CBool _notifyBeats;
		private CBool _notifyBars;
		private CBool _notifyGrid;
		private CBool _notifyBarProgression;
		private CBool _notifyBeatProgression;
		private CName _syncTrack;

		[Ordinal(3)] 
		[RED("notifyBeats")] 
		public CBool NotifyBeats
		{
			get
			{
				if (_notifyBeats == null)
				{
					_notifyBeats = (CBool) CR2WTypeManager.Create("Bool", "notifyBeats", cr2w, this);
				}
				return _notifyBeats;
			}
			set
			{
				if (_notifyBeats == value)
				{
					return;
				}
				_notifyBeats = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("notifyBars")] 
		public CBool NotifyBars
		{
			get
			{
				if (_notifyBars == null)
				{
					_notifyBars = (CBool) CR2WTypeManager.Create("Bool", "notifyBars", cr2w, this);
				}
				return _notifyBars;
			}
			set
			{
				if (_notifyBars == value)
				{
					return;
				}
				_notifyBars = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("notifyGrid")] 
		public CBool NotifyGrid
		{
			get
			{
				if (_notifyGrid == null)
				{
					_notifyGrid = (CBool) CR2WTypeManager.Create("Bool", "notifyGrid", cr2w, this);
				}
				return _notifyGrid;
			}
			set
			{
				if (_notifyGrid == value)
				{
					return;
				}
				_notifyGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("notifyBarProgression")] 
		public CBool NotifyBarProgression
		{
			get
			{
				if (_notifyBarProgression == null)
				{
					_notifyBarProgression = (CBool) CR2WTypeManager.Create("Bool", "notifyBarProgression", cr2w, this);
				}
				return _notifyBarProgression;
			}
			set
			{
				if (_notifyBarProgression == value)
				{
					return;
				}
				_notifyBarProgression = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("notifyBeatProgression")] 
		public CBool NotifyBeatProgression
		{
			get
			{
				if (_notifyBeatProgression == null)
				{
					_notifyBeatProgression = (CBool) CR2WTypeManager.Create("Bool", "notifyBeatProgression", cr2w, this);
				}
				return _notifyBeatProgression;
			}
			set
			{
				if (_notifyBeatProgression == value)
				{
					return;
				}
				_notifyBeatProgression = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		public gameaudioMusicSyncComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
