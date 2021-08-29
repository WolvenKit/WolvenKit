using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVisualTagToNPCMetadata : RedBaseClass
	{
		private CArray<CName> _visualTags;
		private CName _foleyNPCMetadata;

		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
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
