using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimSetupResource : CResource
	{
		private CArray<CResourceReference<animAnimSet>> _dependencies;

		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<animAnimSet>> Dependencies
		{
			get => GetProperty(ref _dependencies);
			set => SetProperty(ref _dependencies, value);
		}
	}
}
