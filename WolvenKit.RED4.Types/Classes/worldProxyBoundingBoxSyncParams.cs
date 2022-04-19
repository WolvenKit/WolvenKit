using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxyBoundingBoxSyncParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("positiveAxis")] 
		public CEnum<worldProxyBBoxSyncOptions> PositiveAxis
		{
			get => GetPropertyValue<CEnum<worldProxyBBoxSyncOptions>>();
			set => SetPropertyValue<CEnum<worldProxyBBoxSyncOptions>>(value);
		}

		[Ordinal(1)] 
		[RED("negativeAxis")] 
		public CEnum<worldProxyBBoxSyncOptions> NegativeAxis
		{
			get => GetPropertyValue<CEnum<worldProxyBBoxSyncOptions>>();
			set => SetPropertyValue<CEnum<worldProxyBBoxSyncOptions>>(value);
		}

		[Ordinal(2)] 
		[RED("pullRange")] 
		public CFloat PullRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("makeStackable")] 
		public CBool MakeStackable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("stackOffset")] 
		public Vector3 StackOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public worldProxyBoundingBoxSyncParams()
		{
			PullRange = 0.050000F;
			StackOffset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
