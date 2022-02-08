using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoloTable : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("meshTable")] 
		public CArray<CHandle<entMeshComponent>> MeshTable
		{
			get => GetPropertyValue<CArray<CHandle<entMeshComponent>>>();
			set => SetPropertyValue<CArray<CHandle<entMeshComponent>>>(value);
		}

		[Ordinal(98)] 
		[RED("componentCounter")] 
		public CInt32 ComponentCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(99)] 
		[RED("currentMesh")] 
		public CInt32 CurrentMesh
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(100)] 
		[RED("glitchMesh")] 
		public CHandle<entMeshComponent> GlitchMesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		public HoloTable()
		{
			MeshTable = new();
		}
	}
}
