using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviortweakTargetLocation : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public Vector3 Speed
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("coverId")] 
		public AIObjectId CoverId
		{
			get => GetPropertyValue<AIObjectId>();
			set => SetPropertyValue<AIObjectId>(value);
		}

		[Ordinal(4)] 
		[RED("hasPosition")] 
		public CBool HasPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hasSpeed")] 
		public CBool HasSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviortweakTargetLocation()
		{
			Position = new();
			Speed = new();
			CoverId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
