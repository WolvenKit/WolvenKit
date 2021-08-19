using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionRegisterRequest : gameScriptableSystemRequest
	{
		private CHandle<gamePersistentState> _requester;
		private CName _attitudeGroup;
		private CBool _register;

		[Ordinal(0)] 
		[RED("requester")] 
		public CHandle<gamePersistentState> Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}

		[Ordinal(1)] 
		[RED("attitudeGroup")] 
		public CName AttitudeGroup
		{
			get => GetProperty(ref _attitudeGroup);
			set => SetProperty(ref _attitudeGroup, value);
		}

		[Ordinal(2)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}

		public PreventionRegisterRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
