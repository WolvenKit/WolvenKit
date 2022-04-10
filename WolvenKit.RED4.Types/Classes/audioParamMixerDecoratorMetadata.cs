using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioParamMixerDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("inParams")] 
		public CArray<audioMixParamDescription> InParams
		{
			get => GetPropertyValue<CArray<audioMixParamDescription>>();
			set => SetPropertyValue<CArray<audioMixParamDescription>>(value);
		}

		[Ordinal(2)] 
		[RED("outputName")] 
		public CName OutputName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<audioMixParamsAction> Operation
		{
			get => GetPropertyValue<CEnum<audioMixParamsAction>>();
			set => SetPropertyValue<CEnum<audioMixParamsAction>>(value);
		}

		[Ordinal(4)] 
		[RED("globalOutput")] 
		public CBool GlobalOutput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioParamMixerDecoratorMetadata()
		{
			InParams = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
