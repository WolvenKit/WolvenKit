using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPrefabVariantsList : ISerializable
	{
		private CArray<CName> _activeVariants;

		[Ordinal(0)] 
		[RED("activeVariants")] 
		public CArray<CName> ActiveVariants
		{
			get => GetProperty(ref _activeVariants);
			set => SetProperty(ref _activeVariants, value);
		}
	}
}
