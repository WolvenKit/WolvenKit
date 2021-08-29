using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefTreeVariablesList : RedBaseClass
	{
		private CArray<CHandle<LibTreeDefTreeVariable>> _list;

		[Ordinal(0)] 
		[RED("list")] 
		public CArray<CHandle<LibTreeDefTreeVariable>> List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}
	}
}
