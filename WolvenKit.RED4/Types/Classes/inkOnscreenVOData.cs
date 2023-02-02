using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkOnscreenVOData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CRUID Text
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		public inkOnscreenVOData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
