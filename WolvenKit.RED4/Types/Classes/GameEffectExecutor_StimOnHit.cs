using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameEffectExecutor_StimOnHit : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(2)] 
		[RED("silentStimType")] 
		public CEnum<gamedataStimType> SilentStimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(3)] 
		[RED("suppressedByStimTypes")] 
		public CArray<CEnum<gamedataStimType>> SuppressedByStimTypes
		{
			get => GetPropertyValue<CArray<CEnum<gamedataStimType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataStimType>>>(value);
		}

		public GameEffectExecutor_StimOnHit()
		{
			SuppressedByStimTypes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
