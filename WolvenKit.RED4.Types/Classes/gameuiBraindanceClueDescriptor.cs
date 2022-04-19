using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBraindanceClueDescriptor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameuiEClueDescriptorMode> Mode
		{
			get => GetPropertyValue<CEnum<gameuiEClueDescriptorMode>>();
			set => SetPropertyValue<CEnum<gameuiEClueDescriptorMode>>(value);
		}

		[Ordinal(1)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetPropertyValue<CEnum<gameuiEBraindanceLayer>>();
			set => SetPropertyValue<CEnum<gameuiEBraindanceLayer>>(value);
		}

		[Ordinal(2)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiBraindanceClueDescriptor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
