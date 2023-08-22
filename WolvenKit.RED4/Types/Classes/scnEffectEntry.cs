using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnEffectEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("effectInstanceId")] 
		public scnEffectInstanceId EffectInstanceId
		{
			get => GetPropertyValue<scnEffectInstanceId>();
			set => SetPropertyValue<scnEffectInstanceId>(value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnEffectEntry()
		{
			EffectInstanceId = new scnEffectInstanceId { EffectId = new scnEffectId { Id = uint.MaxValue }, Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
