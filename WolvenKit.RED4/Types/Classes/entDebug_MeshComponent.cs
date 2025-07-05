using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entDebug_MeshComponent : entMeshComponent
	{
		[Ordinal(27)] 
		[RED("filterName")] 
		public CString FilterName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public entDebug_MeshComponent()
		{
			FilterName = "Other";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
