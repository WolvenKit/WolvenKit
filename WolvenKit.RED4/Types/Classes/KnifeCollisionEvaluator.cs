using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KnifeCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		[Ordinal(0)] 
		[RED("projectileStopAndStick")] 
		public CBool ProjectileStopAndStick
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public KnifeCollisionEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
