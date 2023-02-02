using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAddBraindanceClue_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetPropertyValue<CEnum<gameuiEBraindanceLayer>>();
			set => SetPropertyValue<CEnum<gameuiEBraindanceLayer>>(value);
		}

		public questAddBraindanceClue_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
