using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageDestructionResource : CResource
	{
		private CArray<CHandle<worldFoliageDestructionMapping>> _mappings;

		[Ordinal(1)] 
		[RED("mappings")] 
		public CArray<CHandle<worldFoliageDestructionMapping>> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}
	}
}
