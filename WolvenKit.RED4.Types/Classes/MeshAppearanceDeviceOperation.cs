using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeshAppearanceDeviceOperation : DeviceOperationBase
	{
		private CName _meshesAppearence;

		[Ordinal(5)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get => GetProperty(ref _meshesAppearence);
			set => SetProperty(ref _meshesAppearence, value);
		}
	}
}
