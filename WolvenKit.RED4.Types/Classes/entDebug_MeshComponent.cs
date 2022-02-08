using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDebug_MeshComponent : entMeshComponent
	{
		[Ordinal(24)] 
		[RED("filterName")] 
		public CString FilterName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public entDebug_MeshComponent()
		{
			FilterName = "Other";
		}
	}
}
