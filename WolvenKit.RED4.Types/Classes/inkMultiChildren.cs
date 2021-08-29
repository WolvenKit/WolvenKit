using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMultiChildren : inkChildren
	{
		private CArray<CHandle<inkWidget>> _children;

		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<inkWidget>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}
	}
}
