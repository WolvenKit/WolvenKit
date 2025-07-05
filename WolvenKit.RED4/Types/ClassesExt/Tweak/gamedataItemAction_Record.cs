
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemAction_Record
	{
		[RED("isDefaultLootChoice")]
		[REDProperty(IsIgnored = true)]
		public CBool IsDefaultLootChoice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("removeAfterUse")]
		[REDProperty(IsIgnored = true)]
		public CBool RemoveAfterUse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
