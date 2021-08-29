using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_TerminateGameEffect : gameEffectExecutor
	{
		private CBool _onlyWithPlayerInstigator;

		[Ordinal(1)] 
		[RED("onlyWithPlayerInstigator")] 
		public CBool OnlyWithPlayerInstigator
		{
			get => GetProperty(ref _onlyWithPlayerInstigator);
			set => SetProperty(ref _onlyWithPlayerInstigator, value);
		}
	}
}
