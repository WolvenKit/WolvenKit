using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIAlertedStateDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("attackInstigatorPosition")] 
		public Vector4 AttackInstigatorPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public AIAlertedStateDelegate()
		{
			AttackInstigatorPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
