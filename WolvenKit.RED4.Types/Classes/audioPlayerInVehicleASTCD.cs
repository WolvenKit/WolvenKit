using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPlayerInVehicleASTCD : audioAudioStateTransitionConditionData
	{
		private CBool _isInside;

		[Ordinal(1)] 
		[RED("isInside")] 
		public CBool IsInside
		{
			get => GetProperty(ref _isInside);
			set => SetProperty(ref _isInside, value);
		}
	}
}
