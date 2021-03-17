using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthEvents : HighLevelTransition
	{
		private CBool _stealthEffectActivated;

		[Ordinal(0)] 
		[RED("stealthEffectActivated")] 
		public CBool StealthEffectActivated
		{
			get => GetProperty(ref _stealthEffectActivated);
			set => SetProperty(ref _stealthEffectActivated, value);
		}

		public StealthEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
