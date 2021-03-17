using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetRevealedInNetwork : redEvent
	{
		private CBool _wasRevealed;

		[Ordinal(0)] 
		[RED("wasRevealed")] 
		public CBool WasRevealed
		{
			get => GetProperty(ref _wasRevealed);
			set => SetProperty(ref _wasRevealed, value);
		}

		public SetRevealedInNetwork(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
