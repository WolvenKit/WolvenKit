using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EvaluateVisionModeRequest : gameScriptableSystemRequest
	{
		private CEnum<gameVisionModeType> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameVisionModeType> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
