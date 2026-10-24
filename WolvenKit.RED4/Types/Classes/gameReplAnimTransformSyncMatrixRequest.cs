using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplAnimTransformSyncMatrixRequest : gameReplAnimTransformRequestBase
	{
		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public gameReplAnimTransformSyncMatrixRequest()
		{
			Transform = new Transform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
