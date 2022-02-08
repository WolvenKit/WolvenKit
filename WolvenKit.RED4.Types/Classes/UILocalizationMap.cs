using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UILocalizationMap : IScriptable
	{
		[Ordinal(0)] 
		[RED("map")] 
		public CArray<UILocRecord> Map
		{
			get => GetPropertyValue<CArray<UILocRecord>>();
			set => SetPropertyValue<CArray<UILocRecord>>(value);
		}

		public UILocalizationMap()
		{
			Map = new();
		}
	}
}
