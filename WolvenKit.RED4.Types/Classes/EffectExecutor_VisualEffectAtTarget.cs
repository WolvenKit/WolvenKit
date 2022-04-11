using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_VisualEffectAtTarget : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("effect")] 
		public gameFxResource Effect
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(2)] 
		[RED("ignoreTimeDilation")] 
		public CBool IgnoreTimeDilation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EffectExecutor_VisualEffectAtTarget()
		{
			Effect = new();
		}
	}
}
