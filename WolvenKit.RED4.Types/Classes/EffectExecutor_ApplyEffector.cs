using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_ApplyEffector : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("effector")] 
		public TweakDBID Effector
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
