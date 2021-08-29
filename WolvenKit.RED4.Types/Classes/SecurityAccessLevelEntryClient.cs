using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAccessLevelEntryClient : SecurityAccessLevelEntry
	{
		private CEnum<ESecurityAccessLevel> _level;

		[Ordinal(2)] 
		[RED("level")] 
		public CEnum<ESecurityAccessLevel> Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}
	}
}
