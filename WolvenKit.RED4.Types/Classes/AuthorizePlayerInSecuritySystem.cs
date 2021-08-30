using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AuthorizePlayerInSecuritySystem : redEvent
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

		public AuthorizePlayerInSecuritySystem()
		{
			_authorize = true;
			_forceRemoveFromBlacklist = true;
			_eSL = new() { Value = Enums.ESecurityAccessLevel.ESL_4 };
		}
	}
}
