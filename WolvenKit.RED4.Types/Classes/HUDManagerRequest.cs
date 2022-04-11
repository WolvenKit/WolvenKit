using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDManagerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public HUDManagerRequest()
		{
			OwnerID = new();
		}
	}
}
