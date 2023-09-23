using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceMoveInCombatWhistleEffector : ForceMoveInCombatEffector
	{
		[Ordinal(2)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public ForceMoveInCombatWhistleEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
