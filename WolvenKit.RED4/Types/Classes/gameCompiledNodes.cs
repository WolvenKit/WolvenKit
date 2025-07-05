using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCompiledNodes : ISerializable
	{
		[Ordinal(0)] 
		[RED("compiledSmartObjects")] 
		public CArray<gameCompiledSmartObjectNode> CompiledSmartObjects
		{
			get => GetPropertyValue<CArray<gameCompiledSmartObjectNode>>();
			set => SetPropertyValue<CArray<gameCompiledSmartObjectNode>>(value);
		}

		public gameCompiledNodes()
		{
			CompiledSmartObjects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
