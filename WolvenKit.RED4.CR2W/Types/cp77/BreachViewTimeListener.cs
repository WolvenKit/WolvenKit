using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BreachViewTimeListener : tickScriptTimeDilationListener
	{
		private wCHandle<gameObject> _myOwner;

		[Ordinal(0)] 
		[RED("myOwner")] 
		public wCHandle<gameObject> MyOwner
		{
			get
			{
				if (_myOwner == null)
				{
					_myOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "myOwner", cr2w, this);
				}
				return _myOwner;
			}
			set
			{
				if (_myOwner == value)
				{
					return;
				}
				_myOwner = value;
				PropertySet(this);
			}
		}

		public BreachViewTimeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
