using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkSyncedMasterAnimByTime : animAnimNode_SkFrameAnim
	{
		[Ordinal(34)] 
		[RED("syncTag")] 
		public CName SyncTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_SkSyncedMasterAnimByTime()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
