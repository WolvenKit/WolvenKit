using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkSyncedMasterAnim : animAnimNode_SkSpeedAnim
	{
		private CName _syncTag;

		[Ordinal(31)] 
		[RED("syncTag")] 
		public CName SyncTag
		{
			get => GetProperty(ref _syncTag);
			set => SetProperty(ref _syncTag, value);
		}
	}
}
