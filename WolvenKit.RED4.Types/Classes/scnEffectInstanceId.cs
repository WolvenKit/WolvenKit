using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnEffectInstanceId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("effectId")] 
		public scnEffectId EffectId
		{
			get => GetPropertyValue<scnEffectId>();
			set => SetPropertyValue<scnEffectId>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnEffectInstanceId()
		{
			EffectId = new() { Id = 4294967295 };
			Id = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
