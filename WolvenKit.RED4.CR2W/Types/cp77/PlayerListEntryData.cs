using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerListEntryData : CVariable
	{
		private wCHandle<gameObject> _playerObject;
		private wCHandle<inkWidget> _playerListEntry;

		[Ordinal(0)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(1)] 
		[RED("playerListEntry")] 
		public wCHandle<inkWidget> PlayerListEntry
		{
			get => GetProperty(ref _playerListEntry);
			set => SetProperty(ref _playerListEntry, value);
		}

		public PlayerListEntryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
