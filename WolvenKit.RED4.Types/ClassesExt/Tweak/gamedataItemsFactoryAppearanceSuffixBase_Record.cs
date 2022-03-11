
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemsFactoryAppearanceSuffixBase_Record
	{
		[RED("instantSwitch")]
		[REDProperty(IsIgnored = true)]
		public CBool InstantSwitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("scriptedFunction")]
		[REDProperty(IsIgnored = true)]
		public CName ScriptedFunction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("scriptedSystem")]
		[REDProperty(IsIgnored = true)]
		public CName ScriptedSystem
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
