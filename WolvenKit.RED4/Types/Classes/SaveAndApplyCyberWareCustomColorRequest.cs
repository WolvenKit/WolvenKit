using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SaveAndApplyCyberWareCustomColorRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("primaryColorIndex")] 
		public CUInt8 PrimaryColorIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("secondaryColorIndex")] 
		public CUInt8 SecondaryColorIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public SaveAndApplyCyberWareCustomColorRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
