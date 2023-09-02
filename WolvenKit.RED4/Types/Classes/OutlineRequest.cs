using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OutlineRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public CName Requester
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("outlineDuration")] 
		public CFloat OutlineDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("outlineData")] 
		public OutlineData OutlineData
		{
			get => GetPropertyValue<OutlineData>();
			set => SetPropertyValue<OutlineData>(value);
		}

		public OutlineRequest()
		{
			OutlineData = new OutlineData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
