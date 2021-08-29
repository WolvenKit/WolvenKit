using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiUIGameState : ISerializable
	{
		private CArray<CHandle<gameuiBaseUIData>> _uiData;

		[Ordinal(0)] 
		[RED("uiData")] 
		public CArray<CHandle<gameuiBaseUIData>> UiData
		{
			get => GetProperty(ref _uiData);
			set => SetProperty(ref _uiData, value);
		}
	}
}
