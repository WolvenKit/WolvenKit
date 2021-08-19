using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleGameplayContextDecisions : InputContextTransitionDecisions
	{
		private CHandle<redCallbackObject> _callbackID;

		[Ordinal(0)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}

		public VehicleGameplayContextDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
