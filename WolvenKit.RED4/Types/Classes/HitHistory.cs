using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitHistory : IScriptable
	{
		[Ordinal(0)] 
		[RED("hitHistory")] 
		public CArray<HitHistoryItem> HitHistory_
		{
			get => GetPropertyValue<CArray<HitHistoryItem>>();
			set => SetPropertyValue<CArray<HitHistoryItem>>(value);
		}

		[Ordinal(1)] 
		[RED("maxEntries")] 
		public CInt32 MaxEntries
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public HitHistory()
		{
			HitHistory_ = new();
			MaxEntries = 5;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
