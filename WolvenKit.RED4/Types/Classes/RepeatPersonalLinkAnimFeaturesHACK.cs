using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RepeatPersonalLinkAnimFeaturesHACK : redEvent
	{
		[Ordinal(0)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public RepeatPersonalLinkAnimFeaturesHACK()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
