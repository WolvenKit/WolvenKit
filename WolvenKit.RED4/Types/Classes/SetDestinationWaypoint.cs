using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetDestinationWaypoint : AIActionHelperTask
	{
		[Ordinal(5)] 
		[RED("refTargetType")] 
		public CEnum<EAITargetType> RefTargetType
		{
			get => GetPropertyValue<CEnum<EAITargetType>>();
			set => SetPropertyValue<CEnum<EAITargetType>>(value);
		}

		[Ordinal(6)] 
		[RED("findClosest")] 
		public CBool FindClosest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("waypointsName")] 
		public CName WaypointsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("destinations")] 
		public CArray<Vector4> Destinations
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(9)] 
		[RED("finalDestinations")] 
		public CArray<Vector4> FinalDestinations
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		public SetDestinationWaypoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
