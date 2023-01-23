using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SInspectableClue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SInspectableClue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
