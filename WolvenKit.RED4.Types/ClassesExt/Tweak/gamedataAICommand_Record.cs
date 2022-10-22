
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAICommand_Record
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
	}
}
