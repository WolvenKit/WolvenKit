using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAppearanceToNPCMetadata : RedBaseClass
	{
		private CArray<CName> _appearances;
		private CName _foleyNPCMetadata;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(1)] 
		[RED("foleyNPCMetadata")] 
		public CName FoleyNPCMetadata
		{
			get => GetProperty(ref _foleyNPCMetadata);
			set => SetProperty(ref _foleyNPCMetadata, value);
		}
	}
}
