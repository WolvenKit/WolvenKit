using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneMarkerInternalsAnimEventEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startName")] 
		public CName StartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("endName")] 
		public CName EndName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("startPos")] 
		public Vector3 StartPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("endPos")] 
		public Vector3 EndPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("startDir")] 
		public Vector3 StartDir
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("endDir")] 
		public Vector3 EndDir
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public scnSceneMarkerInternalsAnimEventEntry()
		{
			StartPos = new Vector3();
			EndPos = new Vector3();
			StartDir = new Vector3();
			EndDir = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
