using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatCheckPrereq : gamePlayerScriptableSystemRequest
	{
		private CBool _register;
		private CHandle<StatCheckPrereqState> _statCheckState;

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}

		[Ordinal(2)] 
		[RED("statCheckState")] 
		public CHandle<StatCheckPrereqState> StatCheckState
		{
			get => GetProperty(ref _statCheckState);
			set => SetProperty(ref _statCheckState, value);
		}

		public ModifyStatCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
