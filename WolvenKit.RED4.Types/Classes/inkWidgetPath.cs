using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetPath : RedBaseClass
	{
		private CArray<CName> _names;

		[Ordinal(0)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}
	}
}
