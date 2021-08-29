using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Retarget : animAnimNode_OnePoseInput
	{
		private CResourceReference<animRig> _refRig;
		private CHandle<animIAnimNode_PostProcess> _postProcess;

		[Ordinal(12)] 
		[RED("refRig")] 
		public CResourceReference<animRig> RefRig
		{
			get => GetProperty(ref _refRig);
			set => SetProperty(ref _refRig, value);
		}

		[Ordinal(13)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get => GetProperty(ref _postProcess);
			set => SetProperty(ref _postProcess, value);
		}
	}
}
