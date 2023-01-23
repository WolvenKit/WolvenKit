using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageRawItem : ISerializable
	{
		[Ordinal(0)] 
		[RED("Mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(1)] 
		[RED("MeshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("Position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("Rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(4)] 
		[RED("Scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldFoliageRawItem()
		{
			Position = new();
			Rotation = new() { R = 1.000000F };
			Scale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
