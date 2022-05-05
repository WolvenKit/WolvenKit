using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConstantStatPoolPrereqListener : BaseStatPoolPrereqListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<ConstantStatPoolPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<ConstantStatPoolPrereqState>>();
			set => SetPropertyValue<CWeakHandle<ConstantStatPoolPrereqState>>(value);
		}

		public ConstantStatPoolPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
