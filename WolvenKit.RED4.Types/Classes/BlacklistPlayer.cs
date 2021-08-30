using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlacklistPlayer : redEvent
	{
		private CBool _blacklist;
		private CEnum<BlacklistReason> _reason;
		private CBool _forceRemoveAuthorization;

		[Ordinal(0)] 
		[RED("blacklist")] 
		public CBool Blacklist
		{
			get => GetProperty(ref _blacklist);
			set => SetProperty(ref _blacklist, value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CEnum<BlacklistReason> Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		[Ordinal(2)] 
		[RED("forceRemoveAuthorization")] 
		public CBool ForceRemoveAuthorization
		{
			get => GetProperty(ref _forceRemoveAuthorization);
			set => SetProperty(ref _forceRemoveAuthorization, value);
		}

		public BlacklistPlayer()
		{
			_blacklist = true;
			_reason = new() { Value = Enums.BlacklistReason.COMBAT };
		}
	}
}
