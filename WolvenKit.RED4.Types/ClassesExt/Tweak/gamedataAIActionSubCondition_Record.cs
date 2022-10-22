
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionSubCondition_Record
	{
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
