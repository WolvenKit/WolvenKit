using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVertexAnimationMapper : RedBaseClass
	{
		private CArray<entVertexAnimationMapperEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<entVertexAnimationMapperEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
