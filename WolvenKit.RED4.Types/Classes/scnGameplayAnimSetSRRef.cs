using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnGameplayAnimSetSRRef : RedBaseClass
	{
		private CResourceAsyncReference<animAnimSet> _asyncAnimSet;

		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public CResourceAsyncReference<animAnimSet> AsyncAnimSet
		{
			get => GetProperty(ref _asyncAnimSet);
			set => SetProperty(ref _asyncAnimSet, value);
		}
	}
}
