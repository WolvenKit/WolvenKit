using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkSyncedMasterAnim : animAnimNode_SkSpeedAnim
	{
		[Ordinal(31)] 
		[RED("syncTag")] 
		public CName SyncTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_SkSyncedMasterAnim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
