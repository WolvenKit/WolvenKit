using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class navLocomotionPathResource : CResource
	{
		private CArray<CHandle<navLocomotionPath>> _paths;

		[Ordinal(1)] 
		[RED("paths")] 
		public CArray<CHandle<navLocomotionPath>> Paths
		{
			get => GetProperty(ref _paths);
			set => SetProperty(ref _paths, value);
		}
	}
}
