using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnEffectInstance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("effectInstanceId")] 
		public scnEffectInstanceId EffectInstanceId
		{
			get => GetPropertyValue<scnEffectInstanceId>();
			set => SetPropertyValue<scnEffectInstanceId>(value);
		}

		[Ordinal(1)] 
		[RED("compiledEffect")] 
		public worldCompiledEffectInfo CompiledEffect
		{
			get => GetPropertyValue<worldCompiledEffectInfo>();
			set => SetPropertyValue<worldCompiledEffectInfo>(value);
		}

		public scnEffectInstance()
		{
			EffectInstanceId = new() { EffectId = new() { Id = 4294967295 }, Id = 4294967295 };
			CompiledEffect = new() { PlacementTags = new(), ComponentNames = new(), RelativePositions = new(), RelativeRotations = new(), PlacementInfos = new(), EventsSortedByRUID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
