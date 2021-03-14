using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameIObjectScriptBase : IScriptable
	{
		private CHandle<gameObject> _gameObject;

		[Ordinal(0)] 
		[RED("gameObject")] 
		public CHandle<gameObject> GameObject
		{
			get
			{
				if (_gameObject == null)
				{
					_gameObject = (CHandle<gameObject>) CR2WTypeManager.Create("handle:gameObject", "gameObject", cr2w, this);
				}
				return _gameObject;
			}
			set
			{
				if (_gameObject == value)
				{
					return;
				}
				_gameObject = value;
				PropertySet(this);
			}
		}

		public gameIObjectScriptBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
