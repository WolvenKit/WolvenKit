using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnEffectDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public scnEffectId Id
		{
			get => GetPropertyValue<scnEffectId>();
			set => SetPropertyValue<scnEffectId>(value);
		}

		[Ordinal(1)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		public scnEffectDef()
		{
			Id = new scnEffectId { Id = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
