using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_ColliderComponent : gameHitShapeBase
	{
		private CArray<CName> _componentNames;

		[Ordinal(3)] 
		[RED("componentNames")] 
		public CArray<CName> ComponentNames
		{
			get
			{
				if (_componentNames == null)
				{
					_componentNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "componentNames", cr2w, this);
				}
				return _componentNames;
			}
			set
			{
				if (_componentNames == value)
				{
					return;
				}
				_componentNames = value;
				PropertySet(this);
			}
		}

		public gameHitShape_ColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
