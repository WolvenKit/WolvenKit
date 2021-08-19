using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleScreenProjectionGameController : gameuiProjectedHUDGameController
	{
		private CHandle<redCallbackObject> _onTargetHitCallback;

		[Ordinal(9)] 
		[RED("OnTargetHitCallback")] 
		public CHandle<redCallbackObject> OnTargetHitCallback
		{
			get => GetProperty(ref _onTargetHitCallback);
			set => SetProperty(ref _onTargetHitCallback, value);
		}

		public sampleScreenProjectionGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
