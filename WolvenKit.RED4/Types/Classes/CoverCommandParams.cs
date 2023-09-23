using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CoverCommandParams : IScriptable
	{
		[Ordinal(0)] 
		[RED("exposureMethods")] 
		public CArray<CEnum<AICoverExposureMethod>> ExposureMethods
		{
			get => GetPropertyValue<CArray<CEnum<AICoverExposureMethod>>>();
			set => SetPropertyValue<CArray<CEnum<AICoverExposureMethod>>>(value);
		}

		public CoverCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
