using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneMarkerInternalsEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("eventId")] 
		public scnSceneEventId EventId
		{
			get => GetPropertyValue<scnSceneEventId>();
			set => SetPropertyValue<scnSceneEventId>(value);
		}

		[Ordinal(1)] 
		[RED("startName")] 
		public CName StartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("endName")] 
		public CName EndName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("startDisplayName")] 
		public CName StartDisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("endDisplayName")] 
		public CName EndDisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("startPos")] 
		public Vector4 StartPos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("endPos")] 
		public Vector4 EndPos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("startDir")] 
		public Vector4 StartDir
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("endDir")] 
		public Vector4 EndDir
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(9)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public scnSceneMarkerInternalsEntry()
		{
			EventId = new() { Id = 18446744073709551615 };
			StartPos = new();
			EndPos = new();
			StartDir = new();
			EndDir = new();
		}
	}
}
