using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckAnimSetTags : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("animsetTagToCompare")] 
		public CArray<CName> AnimsetTagToCompare
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public CheckAnimSetTags()
		{
			AnimsetTagToCompare = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
