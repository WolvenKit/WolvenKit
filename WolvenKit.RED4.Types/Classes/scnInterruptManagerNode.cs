using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterruptManagerNode : scnSceneGraphNode
	{
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;

		[Ordinal(3)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetProperty(ref _interruptionOperations);
			set => SetProperty(ref _interruptionOperations, value);
		}
	}
}
