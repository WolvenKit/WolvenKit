using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCompiledSmartObjectNode : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("compiledData")] 
		public CHandle<gameCompiledSmartObjectData> CompiledData
		{
			get => GetPropertyValue<CHandle<gameCompiledSmartObjectData>>();
			set => SetPropertyValue<CHandle<gameCompiledSmartObjectData>>(value);
		}

		[Ordinal(1)] 
		[RED("worldTransform")] 
		public WorldTransform WorldTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		public gameCompiledSmartObjectNode()
		{
			WorldTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
