using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMusicSyncEvent : redEvent
	{
		private CEnum<audioMusicSyncType> _syncType;
		private CFloat _syncParameter;

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
		[RED("syncParameter")] 
		public CFloat SyncParameter
		{
			get
			{
				if (_syncParameter == null)
				{
					_syncParameter = (CFloat) CR2WTypeManager.Create("Float", "syncParameter", cr2w, this);
				}
				return _syncParameter;
			}
			set
			{
				if (_syncParameter == value)
				{
					return;
				}
				_syncParameter = value;
				PropertySet(this);
			}
		}

		public entMusicSyncEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
