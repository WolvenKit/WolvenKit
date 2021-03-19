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
			get => GetProperty(ref _syncType);
			set => SetProperty(ref _syncType, value);
		}

		[Ordinal(1)] 
		[RED("syncParameter")] 
		public CFloat SyncParameter
		{
			get => GetProperty(ref _syncParameter);
			set => SetProperty(ref _syncParameter, value);
		}

		public entMusicSyncEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
