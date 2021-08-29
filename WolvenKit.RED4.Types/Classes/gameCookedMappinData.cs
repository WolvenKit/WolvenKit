using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCookedMappinData : RedBaseClass
	{
		private CUInt32 _journalPathHash;
		private Vector3 _position;
		private CHandle<gamemappinsIMappinVolume> _volume;

		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetProperty(ref _journalPathHash);
			set => SetProperty(ref _journalPathHash, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("volume")] 
		public CHandle<gamemappinsIMappinVolume> Volume
		{
			get => GetProperty(ref _volume);
			set => SetProperty(ref _volume, value);
		}
	}
}
