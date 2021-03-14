using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PingSquad : PuppetAction
	{
		private CBool _shouldForward;

		[Ordinal(25)] 
		[RED("shouldForward")] 
		public CBool ShouldForward
		{
			get
			{
				if (_shouldForward == null)
				{
					_shouldForward = (CBool) CR2WTypeManager.Create("Bool", "shouldForward", cr2w, this);
				}
				return _shouldForward;
			}
			set
			{
				if (_shouldForward == value)
				{
					return;
				}
				_shouldForward = value;
				PropertySet(this);
			}
		}

		public PingSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
