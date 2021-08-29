using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInputHintManagerGameControllerData : gameuiBaseUIData
	{
		private CArray<gameuiInputHintData> _inputHintsData;

		[Ordinal(1)] 
		[RED("inputHintsData")] 
		public CArray<gameuiInputHintData> InputHintsData
		{
			get => GetProperty(ref _inputHintsData);
			set => SetProperty(ref _inputHintsData, value);
		}
	}
}
