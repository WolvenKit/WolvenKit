using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLanguageFontMapper : ISerializable
	{
		private CArray<inkLanguageFontMapping> _mappings;

		[Ordinal(0)] 
		[RED("mappings")] 
		public CArray<inkLanguageFontMapping> Mappings
		{
			get => GetProperty(ref _mappings);
			set => SetProperty(ref _mappings, value);
		}
	}
}
