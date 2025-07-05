using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_PrefabProxy : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("regularMeshColor")] 
		public CColor RegularMeshColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("instancedMeshColor")] 
		public CColor InstancedMeshColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("prefabProxyMeshColor")] 
		public CColor PrefabProxyMeshColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("distinguishInstancedMesh")] 
		public CBool DistinguishInstancedMesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldDebugColoring_PrefabProxy()
		{
			RegularMeshColor = new CColor();
			InstancedMeshColor = new CColor();
			PrefabProxyMeshColor = new CColor();
			DistinguishInstancedMesh = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
