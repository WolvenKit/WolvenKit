using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStylePropertyReference : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("referencedPath")] 
		public CName ReferencedPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkStylePropertyReference()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
