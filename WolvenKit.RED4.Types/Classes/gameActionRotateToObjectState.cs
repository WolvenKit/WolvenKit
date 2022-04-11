using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionRotateToObjectState : gameActionRotateBaseState
	{
		[Ordinal(11)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("completeWhenRotated")] 
		public CBool CompleteWhenRotated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameActionRotateToObjectState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
