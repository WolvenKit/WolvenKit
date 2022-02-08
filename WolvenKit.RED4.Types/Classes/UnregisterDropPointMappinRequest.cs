using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnregisterDropPointMappinRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public UnregisterDropPointMappinRequest()
		{
			OwnerID = new();
			Position = new();
		}
	}
}
