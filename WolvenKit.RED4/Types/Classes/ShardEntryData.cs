using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardEntryData : GenericCodexEntryData
	{
		[Ordinal(12)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ShardEntryData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
