using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityAppearanceColorVariantsArray : ISerializable
	{
		private CName _appearanceName;
		private CArray<CName> _colorVariants;

		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(1)] 
		[RED("colorVariants")] 
		public CArray<CName> ColorVariants
		{
			get => GetProperty(ref _colorVariants);
			set => SetProperty(ref _colorVariants, value);
		}
	}
}
