using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsColliderMesh : physicsICollider
	{
		[Ordinal(8)] 
		[RED("faceMaterials")] 
		public CArray<CName> FaceMaterials
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(9)] 
		[RED("compiledGeometryBuffer")] 
		public DataBuffer CompiledGeometryBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public physicsColliderMesh()
		{
			LocalToBody = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			MaterialApperanceOverrides = new();
			VolumeModifier = 1.000000F;
			FaceMaterials = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
