using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Retarget : animAnimNode_OnePoseInput
	{
		private rRef<animRig> _refRig;
		private CHandle<animIAnimNode_PostProcess> _postProcess;

		[Ordinal(12)] 
		[RED("refRig")] 
		public rRef<animRig> RefRig
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

		public animAnimNode_Retarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
