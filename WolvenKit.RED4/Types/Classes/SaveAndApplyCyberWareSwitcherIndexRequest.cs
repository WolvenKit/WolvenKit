using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SaveAndApplyCyberWareSwitcherIndexRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("switcherIndex")] 
		public CUInt32 SwitcherIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public SaveAndApplyCyberWareSwitcherIndexRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
