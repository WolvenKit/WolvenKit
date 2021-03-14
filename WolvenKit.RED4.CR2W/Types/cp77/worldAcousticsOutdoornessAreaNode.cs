using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAcousticsOutdoornessAreaNode : worldAreaShapeNode
	{
		private CFloat _outdoor;

		[Ordinal(6)] 
		[RED("outdoor")] 
		public CFloat Outdoor
		{
			get
			{
				if (_outdoor == null)
				{
					_outdoor = (CFloat) CR2WTypeManager.Create("Float", "outdoor", cr2w, this);
				}
				return _outdoor;
			}
			set
			{
				if (_outdoor == value)
				{
					return;
				}
				_outdoor = value;
				PropertySet(this);
			}
		}

		public worldAcousticsOutdoornessAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
