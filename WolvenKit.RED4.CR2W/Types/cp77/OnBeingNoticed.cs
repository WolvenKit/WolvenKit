using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnBeingNoticed : redEvent
	{
		private wCHandle<gameObject> _objectThatNoticed;

		[Ordinal(0)] 
		[RED("objectThatNoticed")] 
		public wCHandle<gameObject> ObjectThatNoticed
		{
			get
			{
				if (_objectThatNoticed == null)
				{
					_objectThatNoticed = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "objectThatNoticed", cr2w, this);
				}
				return _objectThatNoticed;
			}
			set
			{
				if (_objectThatNoticed == value)
				{
					return;
				}
				_objectThatNoticed = value;
				PropertySet(this);
			}
		}

		public OnBeingNoticed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
