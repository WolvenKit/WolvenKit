using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStimuliMergeInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataStimType> Type
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(4)] 
		[RED("propagationType")] 
		public CEnum<gamedataStimPropagation> PropagationType
		{
			get => GetPropertyValue<CEnum<gamedataStimPropagation>>();
			set => SetPropertyValue<CEnum<gamedataStimPropagation>>(value);
		}

		[Ordinal(5)] 
		[RED("targets")] 
		public CEnum<gamedataStimTargets> Targets
		{
			get => GetPropertyValue<CEnum<gamedataStimTargets>>();
			set => SetPropertyValue<CEnum<gamedataStimTargets>>(value);
		}

		public gameStimuliMergeInfo()
		{
			Position = new Vector4();
			Radius = -1.000000F;
			Type = Enums.gamedataStimType.Invalid;
			PropagationType = Enums.gamedataStimPropagation.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
