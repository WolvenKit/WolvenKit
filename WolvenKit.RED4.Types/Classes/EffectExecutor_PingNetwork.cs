using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_PingNetwork : gameEffectExecutor_Scripted
	{
		private gameFxResource _fxResource;

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetProperty(ref _fxResource);
			set => SetProperty(ref _fxResource, value);
		}
	}
}
