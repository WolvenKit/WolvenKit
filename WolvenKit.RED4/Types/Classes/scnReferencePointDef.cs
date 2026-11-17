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
			Id = new scnReferencePointId();
			Offset = new Vector3();
			OriginMarker = new scnMarker();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
