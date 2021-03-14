using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorWorkspotList : IScriptable
	{
		private CArray<NodeRef> _spots;

		[Ordinal(0)] 
		[RED("spots")] 
		public CArray<NodeRef> Spots
		{
			get
			{
				if (_spots == null)
				{
					_spots = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "spots", cr2w, this);
				}
				return _spots;
			}
			set
			{
				if (_spots == value)
				{
					return;
				}
				_spots = value;
				PropertySet(this);
			}
		}

		public AIbehaviorWorkspotList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
