using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibleObjectComponent : entIPlacedComponent
	{
		private CHandle<senseVisibleObject> _visibleObject;

		[Ordinal(5)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get
			{
				if (_visibleObject == null)
				{
					_visibleObject = (CHandle<senseVisibleObject>) CR2WTypeManager.Create("handle:senseVisibleObject", "visibleObject", cr2w, this);
				}
				return _visibleObject;
			}
			set
			{
				if (_visibleObject == value)
				{
					return;
				}
				_visibleObject = value;
				PropertySet(this);
			}
		}

		public senseVisibleObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
