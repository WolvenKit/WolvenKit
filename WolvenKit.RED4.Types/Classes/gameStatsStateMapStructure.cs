using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatsStateMapStructure : RedBaseClass
	{
		private CArray<gameStatsObjectID> _keys;
		private CArray<gameSavedStatsData> _values;

		[Ordinal(0)] 
		[RED("keys")] 
		public CArray<gameStatsObjectID> Keys
		{
			get => GetProperty(ref _keys);
			set => SetProperty(ref _keys, value);
		}

		[Ordinal(1)] 
		[RED("values")] 
		public CArray<gameSavedStatsData> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}
	}
}
