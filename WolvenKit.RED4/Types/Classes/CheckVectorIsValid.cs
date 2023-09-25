using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckVectorIsValid : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public CheckVectorIsValid()
		{
			Value = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
