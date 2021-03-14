using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsContainedInShapesPredicate : gameinteractionsIPredicateType
	{
		private CBool _useCameraPosition;

		[Ordinal(0)] 
		[RED("useCameraPosition")] 
		public CBool UseCameraPosition
		{
			get
			{
				if (_useCameraPosition == null)
				{
					_useCameraPosition = (CBool) CR2WTypeManager.Create("Bool", "useCameraPosition", cr2w, this);
				}
				return _useCameraPosition;
			}
			set
			{
				if (_useCameraPosition == value)
				{
					return;
				}
				_useCameraPosition = value;
				PropertySet(this);
			}
		}

		public gameinteractionsContainedInShapesPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
