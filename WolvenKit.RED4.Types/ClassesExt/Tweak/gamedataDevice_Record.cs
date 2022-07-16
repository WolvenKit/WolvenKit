
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDevice_Record
	{
		[RED("audioResourceName")]
		[REDProperty(IsIgnored = true)]
		public CName AudioResourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("RPGActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RPGActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
