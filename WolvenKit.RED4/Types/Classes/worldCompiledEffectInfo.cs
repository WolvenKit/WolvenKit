using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledEffectInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("placementTags")] 
		public CArray<CName> PlacementTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("componentNames")] 
		public CArray<CName> ComponentNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("relativePositions")] 
		public CArray<Vector3> RelativePositions
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(3)] 
		[RED("relativeRotations")] 
		public CArray<Quaternion> RelativeRotations
		{
			get => GetPropertyValue<CArray<Quaternion>>();
			set => SetPropertyValue<CArray<Quaternion>>(value);
		}

		[Ordinal(4)] 
		[RED("placementInfos")] 
		public CArray<worldCompiledEffectPlacementInfo> PlacementInfos
		{
			get => GetPropertyValue<CArray<worldCompiledEffectPlacementInfo>>();
			set => SetPropertyValue<CArray<worldCompiledEffectPlacementInfo>>(value);
		}

		[Ordinal(5)] 
		[RED("eventsSortedByRUID")] 
		public CArray<worldCompiledEffectEventInfo> EventsSortedByRUID
		{
			get => GetPropertyValue<CArray<worldCompiledEffectEventInfo>>();
			set => SetPropertyValue<CArray<worldCompiledEffectEventInfo>>(value);
		}

		public worldCompiledEffectInfo()
		{
			PlacementTags = new();
			ComponentNames = new();
			RelativePositions = new();
			RelativeRotations = new();
			PlacementInfos = new();
			EventsSortedByRUID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
