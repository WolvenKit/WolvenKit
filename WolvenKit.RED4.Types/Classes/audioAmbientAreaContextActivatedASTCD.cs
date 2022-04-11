using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAmbientAreaContextActivatedASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] 
		[RED("areaMixingContext")] 
		public CName AreaMixingContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
