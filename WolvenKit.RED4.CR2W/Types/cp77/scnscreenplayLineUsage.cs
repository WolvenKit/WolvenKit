using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayLineUsage : CVariable
	{
		private scnGenderMask _playerGenderMask;

		[Ordinal(0)] 
		[RED("playerGenderMask")] 
		public scnGenderMask PlayerGenderMask
		{
			get => GetProperty(ref _playerGenderMask);
			set => SetProperty(ref _playerGenderMask, value);
		}

		public scnscreenplayLineUsage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
