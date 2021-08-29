using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWrappedEntIDArray : RedBaseClass
	{
		private CArray<entEntityID> _arr;

		[Ordinal(0)] 
		[RED("arr")] 
		public CArray<entEntityID> Arr
		{
			get => GetProperty(ref _arr);
			set => SetProperty(ref _arr, value);
		}
	}
}
