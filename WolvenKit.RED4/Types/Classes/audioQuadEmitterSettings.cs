using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioQuadEmitterSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("Interleaved")] 
		public CBool Interleaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("Radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("Offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("Angle")] 
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("Events", 4)] 
		public CArrayFixedSize<audioAudEventStruct> Events
		{
			get => GetPropertyValue<CArrayFixedSize<audioAudEventStruct>>();
			set => SetPropertyValue<CArrayFixedSize<audioAudEventStruct>>(value);
		}

		public audioQuadEmitterSettings()
		{
			Offset = new Vector3();
			Events = new(4);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
