using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficCompiledNode : worldNode
	{
		[Ordinal(4)] 
		[RED("aabb")] 
		public Box Aabb
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		public worldTrafficCompiledNode()
		{
			Aabb = new Box { Min = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, Max = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
