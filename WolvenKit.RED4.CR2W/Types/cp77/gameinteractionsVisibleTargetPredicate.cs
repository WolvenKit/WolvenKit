using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsVisibleTargetPredicate : gameinteractionsIPredicateType
	{
		private CBool _stopOnTransparent;

		[Ordinal(0)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get
			{
				if (_stopOnTransparent == null)
				{
					_stopOnTransparent = (CBool) CR2WTypeManager.Create("Bool", "stopOnTransparent", cr2w, this);
				}
				return _stopOnTransparent;
			}
			set
			{
				if (_stopOnTransparent == value)
				{
					return;
				}
				_stopOnTransparent = value;
				PropertySet(this);
			}
		}

		public gameinteractionsVisibleTargetPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
