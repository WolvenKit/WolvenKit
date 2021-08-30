using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDebug_MeshComponent : entMeshComponent
	{
		private CString _filterName;

		[Ordinal(24)] 
		[RED("filterName")] 
		public CString FilterName
		{
			get => GetProperty(ref _filterName);
			set => SetProperty(ref _filterName, value);
		}

		public entDebug_MeshComponent()
		{
			_filterName = new() { Text = "Other" };
		}
	}
}
