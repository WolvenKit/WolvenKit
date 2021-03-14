using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_RestrictMovementToArea : questCombatNodeParams
	{
		private NodeRef _area;

		[Ordinal(0)] 
		[RED("area")] 
		public NodeRef Area
		{
			get
			{
				if (_area == null)
				{
					_area = (NodeRef) CR2WTypeManager.Create("NodeRef", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		public questCombatNodeParams_RestrictMovementToArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
