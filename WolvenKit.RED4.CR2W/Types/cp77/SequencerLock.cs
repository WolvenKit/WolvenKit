using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SequencerLock : redEvent
	{
		private CBool _shouldLock;

		[Ordinal(0)] 
		[RED("shouldLock")] 
		public CBool ShouldLock
		{
			get
			{
				if (_shouldLock == null)
				{
					_shouldLock = (CBool) CR2WTypeManager.Create("Bool", "shouldLock", cr2w, this);
				}
				return _shouldLock;
			}
			set
			{
				if (_shouldLock == value)
				{
					return;
				}
				_shouldLock = value;
				PropertySet(this);
			}
		}

		public SequencerLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
