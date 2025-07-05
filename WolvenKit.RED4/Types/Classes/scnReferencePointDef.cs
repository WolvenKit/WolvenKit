using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnReferencePointDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public scnReferencePointId Id
		{
			get => GetPropertyValue<scnReferencePointId>();
			set => SetPropertyValue<scnReferencePointId>(value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		public scnReferencePointDef()
		{
			Id = new scnReferencePointId { Id = uint.MaxValue };
			Offset = new Vector3();
			OriginMarker = new scnMarker { Type = Enums.scnMarkerType.Global, EntityRef = new gameEntityReference { Names = new() }, IsMounted = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
