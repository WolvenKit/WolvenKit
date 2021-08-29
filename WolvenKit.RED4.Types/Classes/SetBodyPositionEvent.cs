using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBodyPositionEvent : redEvent
	{
		private Vector4 _bodyPosition;
		private entEntityID _bodyPositionID;
		private CBool _pickedUp;

		[Ordinal(0)] 
		[RED("bodyPosition")] 
		public Vector4 BodyPosition
		{
			get => GetProperty(ref _bodyPosition);
			set => SetProperty(ref _bodyPosition, value);
		}

		[Ordinal(1)] 
		[RED("bodyPositionID")] 
		public entEntityID BodyPositionID
		{
			get => GetProperty(ref _bodyPositionID);
			set => SetProperty(ref _bodyPositionID, value);
		}

		[Ordinal(2)] 
		[RED("pickedUp")] 
		public CBool PickedUp
		{
			get => GetProperty(ref _pickedUp);
			set => SetProperty(ref _pickedUp, value);
		}
	}
}
