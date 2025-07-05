
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIWorkspotCond_Record
	{
		[RED("isInWorkspot")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsInWorkspot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("workspotObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WorkspotObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
