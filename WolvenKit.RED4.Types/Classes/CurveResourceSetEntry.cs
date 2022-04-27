using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CurveResourceSetEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("curveResRef")] 
		public CResourceReference<CurveSet> CurveResRef
		{
			get => GetPropertyValue<CResourceReference<CurveSet>>();
			set => SetPropertyValue<CResourceReference<CurveSet>>(value);
		}

		public CurveResourceSetEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
