using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehiclePortalsList : IScriptable
	{
		private CArray<NodeRef> _listPoints;

		[Ordinal(0)] 
		[RED("listPoints")] 
		public CArray<NodeRef> ListPoints
		{
			get
			{
				if (_listPoints == null)
				{
					_listPoints = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "listPoints", cr2w, this);
				}
				return _listPoints;
			}
			set
			{
				if (_listPoints == value)
				{
					return;
				}
				_listPoints = value;
				PropertySet(this);
			}
		}

		public vehiclePortalsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
