using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AuthorizePlayerInSecuritySystem : redEvent
	{
		private CBool _authorize;
		private CBool _forceRemoveFromBlacklist;
		private CEnum<ESecurityAccessLevel> _eSL;

		[Ordinal(0)] 
		[RED("authorize")] 
		public CBool Authorize
		{
			get => GetProperty(ref _authorize);
			set => SetProperty(ref _authorize, value);
		}

		[Ordinal(1)] 
		[RED("forceRemoveFromBlacklist")] 
		public CBool ForceRemoveFromBlacklist
		{
			get => GetProperty(ref _forceRemoveFromBlacklist);
			set => SetProperty(ref _forceRemoveFromBlacklist, value);
		}

		[Ordinal(2)] 
		[RED("ESL")] 
		public CEnum<ESecurityAccessLevel> ESL
		{
			get => GetProperty(ref _eSL);
			set => SetProperty(ref _eSL, value);
		}

		public AuthorizePlayerInSecuritySystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
