using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entClothComponent : entIVisualComponent
	{
		private CResourceReference<CMesh> _mesh;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public entClothComponent()
		{
			_isEnabled = true;
		}
	}
}
