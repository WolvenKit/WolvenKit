using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UILocalizationMap : IScriptable
	{
		private CArray<UILocRecord> _map;

		[Ordinal(0)] 
		[RED("map")] 
		public CArray<UILocRecord> Map
		{
			get => GetProperty(ref _map);
			set => SetProperty(ref _map, value);
		}
	}
}
