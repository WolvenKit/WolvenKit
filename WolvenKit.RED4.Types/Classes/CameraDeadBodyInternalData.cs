using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraDeadBodyInternalData : IScriptable
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("bodyIDs")] 
		public CArray<entEntityID> BodyIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public CameraDeadBodyInternalData()
		{
			OwnerID = new();
			BodyIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
