using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporaryUnequipEvents : UpperBodyEventsTransition
	{
		private CBool _forceOpen;

		[Ordinal(6)] 
		[RED("forceOpen")] 
		public CBool ForceOpen
		{
			get => GetProperty(ref _forceOpen);
			set => SetProperty(ref _forceOpen, value);
		}

		public TemporaryUnequipEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
