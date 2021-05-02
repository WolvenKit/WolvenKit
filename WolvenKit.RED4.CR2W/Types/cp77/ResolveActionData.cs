using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResolveActionData : IScriptable
	{
		private CString _password;

		[Ordinal(0)] 
		[RED("password")] 
		public CString Password
		{
			get => GetProperty(ref _password);
			set => SetProperty(ref _password, value);
		}

		public ResolveActionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
