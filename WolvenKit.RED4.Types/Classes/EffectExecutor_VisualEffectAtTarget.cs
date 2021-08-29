using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_VisualEffectAtTarget : gameEffectExecutor_Scripted
	{
		private gameFxResource _effect;
		private CBool _ignoreTimeDilation;

		[Ordinal(1)] 
		[RED("effect")] 
		public gameFxResource Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(2)] 
		[RED("ignoreTimeDilation")] 
		public CBool IgnoreTimeDilation
		{
			get => GetProperty(ref _ignoreTimeDilation);
			set => SetProperty(ref _ignoreTimeDilation, value);
		}
	}
}
