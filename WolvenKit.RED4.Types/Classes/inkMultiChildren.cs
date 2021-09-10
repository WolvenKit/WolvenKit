using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMultiChildren : inkChildren
	{
		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<inkWidget>> Children
		{
			get => GetPropertyValue<CArray<CHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CHandle<inkWidget>>>(value);
		}

		public inkMultiChildren()
		{
			Children = new();
		}
	}
}
