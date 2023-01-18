using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmitterGroupAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("emitterGroupParams")] 
		public CArray<EmitterGroupParams> EmitterGroupParams_72
		{
			get => GetPropertyValue<CArray<EmitterGroupParams>>();
			set => SetPropertyValue<CArray<EmitterGroupParams>>(value);
		}

		[Ordinal(3)] 
		[RED("EmitterGroupParams")] 
		public CArray<EmitterGroupAreaParams> EmitterGroupParams_88
		{
			get => GetPropertyValue<CArray<EmitterGroupAreaParams>>();
			set => SetPropertyValue<CArray<EmitterGroupAreaParams>>(value);
		}

		public EmitterGroupAreaSettings()
		{
			Enable = true;
			EmitterGroupParams_72 = new();
			EmitterGroupParams_88 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
