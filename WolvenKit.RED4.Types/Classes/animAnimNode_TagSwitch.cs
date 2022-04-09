using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TagSwitch : animAnimNode_BaseSwitch
	{
		[Ordinal(16)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public animAnimNode_TagSwitch()
		{
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
