using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotGlobalProp : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("prop")] 
		public CResourceAsyncReference<entEntityTemplate> Prop
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		public workWorkspotGlobalProp()
		{
			Id = "[Enter Prop ID Here]";
		}
	}
}
