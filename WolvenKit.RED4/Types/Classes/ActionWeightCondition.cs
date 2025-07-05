using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionWeightCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("selectedActionIndex")] 
		public CHandle<AIArgumentMapping> SelectedActionIndex
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("thisIndex")] 
		public CInt32 ThisIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ActionWeightCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
