using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemClearanceEntry : RedBaseClass
	{
		private entEntityID _user;
		private CEnum<ESecurityAccessLevel> _level;

		[Ordinal(0)] 
		[RED("user")] 
		public entEntityID User
		{
			get => GetProperty(ref _user);
			set => SetProperty(ref _user, value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public CEnum<ESecurityAccessLevel> Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}
	}
}
