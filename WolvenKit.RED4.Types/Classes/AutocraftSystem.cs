using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutocraftSystem : gameScriptableSystem
	{
		private CBool _active;
		private CFloat _cycleDuration;
		private gameDelayID _currentDelayID;
		private CArray<gameItemID> _itemsUsed;

		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(1)] 
		[RED("cycleDuration")] 
		public CFloat CycleDuration
		{
			get => GetProperty(ref _cycleDuration);
			set => SetProperty(ref _cycleDuration, value);
		}

		[Ordinal(2)] 
		[RED("currentDelayID")] 
		public gameDelayID CurrentDelayID
		{
			get => GetProperty(ref _currentDelayID);
			set => SetProperty(ref _currentDelayID, value);
		}

		[Ordinal(3)] 
		[RED("itemsUsed")] 
		public CArray<gameItemID> ItemsUsed
		{
			get => GetProperty(ref _itemsUsed);
			set => SetProperty(ref _itemsUsed, value);
		}
	}
}
