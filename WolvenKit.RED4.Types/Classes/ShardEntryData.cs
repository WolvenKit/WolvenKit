using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardEntryData : GenericCodexEntryData
	{
		[Ordinal(10)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
