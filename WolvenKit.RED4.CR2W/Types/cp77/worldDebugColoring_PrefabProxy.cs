using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_PrefabProxy : worldEditorDebugColoringSettings
	{
		private CColor _regularMeshColor;
		private CColor _instancedMeshColor;
		private CColor _prefabProxyMeshColor;
		private CBool _distinguishInstancedMesh;

		[Ordinal(0)] 
		[RED("regularMeshColor")] 
		public CColor RegularMeshColor
		{
			get => GetProperty(ref _regularMeshColor);
			set => SetProperty(ref _regularMeshColor, value);
		}

		[Ordinal(1)] 
		[RED("instancedMeshColor")] 
		public CColor InstancedMeshColor
		{
			get => GetProperty(ref _instancedMeshColor);
			set => SetProperty(ref _instancedMeshColor, value);
		}

		[Ordinal(2)] 
		[RED("prefabProxyMeshColor")] 
		public CColor PrefabProxyMeshColor
		{
			get => GetProperty(ref _prefabProxyMeshColor);
			set => SetProperty(ref _prefabProxyMeshColor, value);
		}

		[Ordinal(3)] 
		[RED("distinguishInstancedMesh")] 
		public CBool DistinguishInstancedMesh
		{
			get => GetProperty(ref _distinguishInstancedMesh);
			set => SetProperty(ref _distinguishInstancedMesh, value);
		}

		public worldDebugColoring_PrefabProxy(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
