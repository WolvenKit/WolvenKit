using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workSyncAnimClip : workAnimClip
	{
		private CName _slotName;
		private Transform _syncOffset;

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(5)] 
		[RED("syncOffset")] 
		public Transform SyncOffset
		{
			get => GetProperty(ref _syncOffset);
			set => SetProperty(ref _syncOffset, value);
		}

		public workSyncAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
