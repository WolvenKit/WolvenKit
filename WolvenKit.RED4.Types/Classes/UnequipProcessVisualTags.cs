using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnequipProcessVisualTags : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("item")] 
		public gameItemID Item
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("isUnequipping")] 
		public CBool IsUnequipping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnequipProcessVisualTags()
		{
			Item = new();
		}
	}
}
