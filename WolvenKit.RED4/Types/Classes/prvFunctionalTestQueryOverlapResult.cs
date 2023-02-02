using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class prvFunctionalTestQueryOverlapResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public prvFunctionalTestQueryOverlapResult()
		{
			EntityID = new();
			Position = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
