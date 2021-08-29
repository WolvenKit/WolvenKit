using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkSyncedMasterAnimByTime : animAnimNode_SkFrameAnim
	{
		private CName _syncTag;

		[Ordinal(34)] 
		[RED("syncTag")] 
		public CName SyncTag
		{
			get => GetProperty(ref _syncTag);
			set => SetProperty(ref _syncTag, value);
		}
	}
}
