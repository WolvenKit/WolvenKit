using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForcedKnockdownEvents : KnockdownEvents
	{
		private CBool _firstUpdate;

		[Ordinal(8)] 
		[RED("firstUpdate")] 
		public CBool FirstUpdate
		{
			get
			{
				if (_firstUpdate == null)
				{
					_firstUpdate = (CBool) CR2WTypeManager.Create("Bool", "firstUpdate", cr2w, this);
				}
				return _firstUpdate;
			}
			set
			{
				if (_firstUpdate == value)
				{
					return;
				}
				_firstUpdate = value;
				PropertySet(this);
			}
		}

		public ForcedKnockdownEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
