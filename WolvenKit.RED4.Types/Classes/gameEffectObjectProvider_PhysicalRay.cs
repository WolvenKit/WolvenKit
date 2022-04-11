using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_PhysicalRay : gameEffectObjectProvider
	{
		[Ordinal(0)] 
		[RED("inputPosition")] 
		public gameEffectInputParameter_Vector InputPosition
		{
			get => GetPropertyValue<gameEffectInputParameter_Vector>();
			set => SetPropertyValue<gameEffectInputParameter_Vector>(value);
		}

		[Ordinal(1)] 
		[RED("inputForward")] 
		public gameEffectInputParameter_Vector InputForward
		{
			get => GetPropertyValue<gameEffectInputParameter_Vector>();
			set => SetPropertyValue<gameEffectInputParameter_Vector>(value);
		}

		[Ordinal(2)] 
		[RED("inputRange")] 
		public gameEffectInputParameter_Float InputRange
		{
			get => GetPropertyValue<gameEffectInputParameter_Float>();
			set => SetPropertyValue<gameEffectInputParameter_Float>(value);
		}

		[Ordinal(3)] 
		[RED("outputRaycastEnd")] 
		public gameEffectOutputParameter_Vector OutputRaycastEnd
		{
			get => GetPropertyValue<gameEffectOutputParameter_Vector>();
			set => SetPropertyValue<gameEffectOutputParameter_Vector>(value);
		}

		[Ordinal(4)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(5)] 
		[RED("queryPreset")] 
		public physicsQueryPreset QueryPreset
		{
			get => GetPropertyValue<physicsQueryPreset>();
			set => SetPropertyValue<physicsQueryPreset>(value);
		}

		public gameEffectObjectProvider_PhysicalRay()
		{
			InputPosition = new();
			InputForward = new();
			InputRange = new();
			OutputRaycastEnd = new() { BlackboardProperty = new() { SerializableID = new(), PropertyPath = new() } };
			QueryPreset = new();
		}
	}
}
