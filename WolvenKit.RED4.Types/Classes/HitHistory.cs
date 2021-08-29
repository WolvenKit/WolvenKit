using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitHistory : IScriptable
	{
		private CArray<HitHistoryItem> _hitHistory;
		private CInt32 _maxEntries;

		[Ordinal(0)] 
		[RED("hitHistory")] 
		public CArray<HitHistoryItem> HitHistory_
		{
			get => GetProperty(ref _hitHistory);
			set => SetProperty(ref _hitHistory, value);
		}

		[Ordinal(1)] 
		[RED("maxEntries")] 
		public CInt32 MaxEntries
		{
			get => GetProperty(ref _maxEntries);
			set => SetProperty(ref _maxEntries, value);
		}
	}
}
