using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiUIGameState : ISerializable
	{
		[Ordinal(0)] 
		[RED("uiData")] 
		public CArray<CHandle<gameuiBaseUIData>> UiData
		{
			get => GetPropertyValue<CArray<CHandle<gameuiBaseUIData>>>();
			set => SetPropertyValue<CArray<CHandle<gameuiBaseUIData>>>(value);
		}

		public gameuiUIGameState()
		{
			UiData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
