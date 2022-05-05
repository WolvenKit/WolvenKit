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
			WorldTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
