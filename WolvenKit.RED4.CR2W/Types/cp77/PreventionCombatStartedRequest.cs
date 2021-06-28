using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionCombatStartedRequest : gameScriptableSystemRequest
	{
		private Vector4 _requesterPosition;
		private wCHandle<gameObject> _requester;

		[Ordinal(0)] 
		[RED("requesterPosition")] 
		public Vector4 RequesterPosition
		{
			get => GetProperty(ref _requesterPosition);
			set => SetProperty(ref _requesterPosition, value);
		}

		[Ordinal(1)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		public PreventionCombatStartedRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
