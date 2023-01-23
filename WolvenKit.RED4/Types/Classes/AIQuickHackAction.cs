using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIQuickHackAction : PuppetAction
	{
		[Ordinal(25)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public AIQuickHackAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
