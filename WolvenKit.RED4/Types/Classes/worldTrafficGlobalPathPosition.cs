using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficGlobalPathPosition : ISerializable
	{
		[Ordinal(0)] 
		[RED("worldPosition")] 
		public Vector3 WorldPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("pathIdx")] 
		public CUInt32 PathIdx
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldTrafficGlobalPathPosition()
		{
			WorldPosition = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
