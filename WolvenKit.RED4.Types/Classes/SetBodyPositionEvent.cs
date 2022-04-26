using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetBodyPositionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bodyPosition")] 
		public Vector4 BodyPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("bodyPositionID")] 
		public entEntityID BodyPositionID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("pickedUp")] 
		public CBool PickedUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetBodyPositionEvent()
		{
			BodyPosition = new();
			BodyPositionID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
