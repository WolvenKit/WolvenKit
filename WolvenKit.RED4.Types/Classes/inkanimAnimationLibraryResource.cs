using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimAnimationLibraryResource : CResource
	{
		private CArray<CHandle<inkanimSequence>> _sequences;

		[Ordinal(1)] 
		[RED("sequences")] 
		public CArray<CHandle<inkanimSequence>> Sequences
		{
			get => GetProperty(ref _sequences);
			set => SetProperty(ref _sequences, value);
		}
	}
}
