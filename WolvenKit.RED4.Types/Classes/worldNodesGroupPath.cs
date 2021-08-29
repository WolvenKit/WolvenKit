using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNodesGroupPath : RedBaseClass
	{
		private CArray<CName> _elements;

		[Ordinal(0)] 
		[RED("elements")] 
		public CArray<CName> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}
	}
}
