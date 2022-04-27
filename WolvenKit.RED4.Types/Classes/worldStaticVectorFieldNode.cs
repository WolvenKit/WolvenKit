using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticVectorFieldNode : worldNode
	{
		[Ordinal(4)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("autoHideDistance")] 
		public CFloat AutoHideDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldStaticVectorFieldNode()
		{
			Direction = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
