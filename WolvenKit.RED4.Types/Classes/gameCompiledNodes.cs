using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCompiledNodes : ISerializable
	{
		private CArray<gameCompiledSmartObjectNode> _compiledSmartObjects;

		[Ordinal(0)] 
		[RED("compiledSmartObjects")] 
		public CArray<gameCompiledSmartObjectNode> CompiledSmartObjects
		{
			get => GetProperty(ref _compiledSmartObjects);
			set => SetProperty(ref _compiledSmartObjects, value);
		}
	}
}
