using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleLock : ActionBool
	{
		private CBool _shouldOpen;

		[Ordinal(25)] 
		[RED("shouldOpen")] 
		public CBool ShouldOpen
		{
			get
			{
				if (_shouldOpen == null)
				{
					_shouldOpen = (CBool) CR2WTypeManager.Create("Bool", "shouldOpen", cr2w, this);
				}
				return _shouldOpen;
			}
			set
			{
				if (_shouldOpen == value)
				{
					return;
				}
				_shouldOpen = value;
				PropertySet(this);
			}
		}

		public ToggleLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
