using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAmbientAreaContextActivatedASTCD : audioAudioStateTransitionConditionData
	{
		private CName _areaMixingContext;

		[Ordinal(1)] 
		[RED("areaMixingContext")] 
		public CName AreaMixingContext
		{
			get => GetProperty(ref _areaMixingContext);
			set => SetProperty(ref _areaMixingContext, value);
		}
	}
}
