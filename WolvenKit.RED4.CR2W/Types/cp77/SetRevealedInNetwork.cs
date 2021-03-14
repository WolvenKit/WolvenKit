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
			get
			{
				if (_wasRevealed == null)
				{
					_wasRevealed = (CBool) CR2WTypeManager.Create("Bool", "wasRevealed", cr2w, this);
				}
				return _wasRevealed;
			}
			set
			{
				if (_wasRevealed == value)
				{
					return;
				}
				_wasRevealed = value;
				PropertySet(this);
			}
		}

		public SetRevealedInNetwork(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
