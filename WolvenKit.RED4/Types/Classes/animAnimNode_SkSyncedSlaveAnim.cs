using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkSyncedSlaveAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("syncTag")] 
		public CName SyncTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_SkSyncedSlaveAnim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
