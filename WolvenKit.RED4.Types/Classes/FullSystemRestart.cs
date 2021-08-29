using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FullSystemRestart : ActionBool
	{
		private CInt32 _restartDuration;

		[Ordinal(25)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetProperty(ref _restartDuration);
			set => SetProperty(ref _restartDuration, value);
		}
	}
}
