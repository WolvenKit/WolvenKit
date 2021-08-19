using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloTable : InteractiveDevice
	{
		private CArray<CHandle<entMeshComponent>> _meshTable;
		private CInt32 _componentCounter;
		private CInt32 _currentMesh;
		private CHandle<entMeshComponent> _glitchMesh;

		[Ordinal(97)] 
		[RED("meshTable")] 
		public CArray<CHandle<entMeshComponent>> MeshTable
		{
			get => GetProperty(ref _meshTable);
			set => SetProperty(ref _meshTable, value);
		}

		[Ordinal(98)] 
		[RED("componentCounter")] 
		public CInt32 ComponentCounter
		{
			get => GetProperty(ref _componentCounter);
			set => SetProperty(ref _componentCounter, value);
		}

		[Ordinal(99)] 
		[RED("currentMesh")] 
		public CInt32 CurrentMesh
		{
			get => GetProperty(ref _currentMesh);
			set => SetProperty(ref _currentMesh, value);
		}

		[Ordinal(100)] 
		[RED("glitchMesh")] 
		public CHandle<entMeshComponent> GlitchMesh
		{
			get => GetProperty(ref _glitchMesh);
			set => SetProperty(ref _glitchMesh, value);
		}

		public HoloTable(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
