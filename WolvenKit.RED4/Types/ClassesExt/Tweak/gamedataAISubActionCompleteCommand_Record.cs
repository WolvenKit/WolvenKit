
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionCompleteCommand_Record
	{
		[RED("checkOneTimeExecutionFlag")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckOneTimeExecutionFlag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("commands")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Commands
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
