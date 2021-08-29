using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRelativeNodePath : RedBaseClass
	{
		private CUInt32 _parentsToSkip;
		private CArray<worldRelativeNodePathElement> _elements;

		[Ordinal(0)] 
		[RED("parentsToSkip")] 
		public CUInt32 ParentsToSkip
		{
			get => GetProperty(ref _parentsToSkip);
			set => SetProperty(ref _parentsToSkip, value);
		}

		[Ordinal(1)] 
		[RED("elements")] 
		public CArray<worldRelativeNodePathElement> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}
	}
}
