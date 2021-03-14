using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestRemoveTransition : redEvent
	{
		private CInt32 _removeTransitionFrom;

		[Ordinal(0)] 
		[RED("removeTransitionFrom")] 
		public CInt32 RemoveTransitionFrom
		{
			get
			{
				if (_removeTransitionFrom == null)
				{
					_removeTransitionFrom = (CInt32) CR2WTypeManager.Create("Int32", "removeTransitionFrom", cr2w, this);
				}
				return _removeTransitionFrom;
			}
			set
			{
				if (_removeTransitionFrom == value)
				{
					return;
				}
				_removeTransitionFrom = value;
				PropertySet(this);
			}
		}

		public QuestRemoveTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
