using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInputHintManagerGameControllerData : gameuiBaseUIData
	{
		[Ordinal(1)] 
		[RED("inputHintsData")] 
		public CArray<gameuiInputHintData> InputHintsData
		{
			get => GetPropertyValue<CArray<gameuiInputHintData>>();
			set => SetPropertyValue<CArray<gameuiInputHintData>>(value);
		}

		public gameuiInputHintManagerGameControllerData()
		{
			InputHintsData = new();
		}
	}
}
