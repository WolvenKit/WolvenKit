using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentWoundMeshes : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ResourceSet")] 
		public CEnum<entdismembermentResourceSetE> ResourceSet
		{
			get => GetPropertyValue<CEnum<entdismembermentResourceSetE>>();
			set => SetPropertyValue<CEnum<entdismembermentResourceSetE>>(value);
		}

		[Ordinal(1)] 
		[RED("Meshes")] 
		public CArray<entdismembermentMeshInfo> Meshes
		{
			get => GetPropertyValue<CArray<entdismembermentMeshInfo>>();
			set => SetPropertyValue<CArray<entdismembermentMeshInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("FillMeshes")] 
		public CArray<entdismembermentFillMeshInfo> FillMeshes
		{
			get => GetPropertyValue<CArray<entdismembermentFillMeshInfo>>();
			set => SetPropertyValue<CArray<entdismembermentFillMeshInfo>>(value);
		}

		public entdismembermentWoundMeshes()
		{
			Meshes = new();
			FillMeshes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
