using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCompiledSmartObjectNode : RedBaseClass
	{
		private CHandle<gameCompiledSmartObjectData> _compiledData;
		private WorldTransform _worldTransform;

		[Ordinal(0)] 
		[RED("compiledData")] 
		public CHandle<gameCompiledSmartObjectData> CompiledData
		{
			get => GetProperty(ref _compiledData);
			set => SetProperty(ref _compiledData, value);
		}

		[Ordinal(1)] 
		[RED("worldTransform")] 
		public WorldTransform WorldTransform
		{
			get => GetProperty(ref _worldTransform);
			set => SetProperty(ref _worldTransform, value);
		}
	}
}
