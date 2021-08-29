using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshChunkMaterials : RedBaseClass
	{
		private CArray<CName> _materialNames;

		[Ordinal(0)] 
		[RED("materialNames")] 
		public CArray<CName> MaterialNames
		{
			get => GetProperty(ref _materialNames);
			set => SetProperty(ref _materialNames, value);
		}
	}
}
