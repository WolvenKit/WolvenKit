using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Transform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
		}
	}
}
