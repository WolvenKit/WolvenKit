
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionWorkspot_Record
	{
		[RED("workspotObject")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WorkspotObject
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
