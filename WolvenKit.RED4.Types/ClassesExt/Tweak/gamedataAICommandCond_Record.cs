
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAICommandCond_Record
	{
		[RED("hasCommands")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> HasCommands
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("hasNewOrOverridenCommands")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> HasNewOrOverridenCommands
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
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
