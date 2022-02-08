using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimTargetData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spawnerRef")] 
		public NodeRef SpawnerRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CName EntryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
