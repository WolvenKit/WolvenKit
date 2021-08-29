using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SetBoneTransform : animAnimNode_OnePoseInput
	{
		private CArray<animSetBoneTransformEntry> _entries;

		[Ordinal(12)] 
		[RED("entries")] 
		public CArray<animSetBoneTransformEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
