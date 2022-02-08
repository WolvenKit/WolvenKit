using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_TerminateGameEffect : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("onlyWithPlayerInstigator")] 
		public CBool OnlyWithPlayerInstigator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
