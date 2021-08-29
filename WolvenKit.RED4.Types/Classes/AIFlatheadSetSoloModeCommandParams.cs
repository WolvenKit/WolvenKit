using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIFlatheadSetSoloModeCommandParams : questScriptedAICommandParams
	{
		private CBool _soloMode;

		[Ordinal(0)] 
		[RED("soloMode")] 
		public CBool SoloMode
		{
			get => GetProperty(ref _soloMode);
			set => SetProperty(ref _soloMode, value);
		}
	}
}
