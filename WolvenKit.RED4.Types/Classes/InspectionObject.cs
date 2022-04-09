using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InspectionObject : gameObject
	{
		[Ordinal(35)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		public InspectionObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
