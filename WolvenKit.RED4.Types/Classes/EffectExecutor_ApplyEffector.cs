using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_ApplyEffector : gameEffectExecutor_Scripted
	{
		private TweakDBID _effector;

		[Ordinal(1)] 
		[RED("effector")] 
		public TweakDBID Effector
		{
			get => GetProperty(ref _effector);
			set => SetProperty(ref _effector, value);
		}
	}
}
