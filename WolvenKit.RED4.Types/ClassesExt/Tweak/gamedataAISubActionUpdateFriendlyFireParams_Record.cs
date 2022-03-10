
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionUpdateFriendlyFireParams_Record
	{
		[RED("updateOnDeactivate")]
		[REDProperty(IsIgnored = true)]
		public CBool UpdateOnDeactivate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
