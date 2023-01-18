using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnBeingTarget : redEvent
	{
		[Ordinal(0)] 
		[RED("objectThatTargets")] 
		public CWeakHandle<gameObject> ObjectThatTargets
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("noLongerTarget")] 
		public CBool NoLongerTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OnBeingTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
