using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterDropPointMappinRequest : gameScriptableSystemRequest
	{
		private entEntityID _ownerID;
		private Vector4 _position;
		private gameNewMappinID _trackingAlternativeMappinID;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("trackingAlternativeMappinID")] 
		public gameNewMappinID TrackingAlternativeMappinID
		{
			get => GetProperty(ref _trackingAlternativeMappinID);
			set => SetProperty(ref _trackingAlternativeMappinID, value);
		}
	}
}
