using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VisualTagsPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("allowedTags")] 
		public CArray<CName> AllowedTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VisualTagsPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
