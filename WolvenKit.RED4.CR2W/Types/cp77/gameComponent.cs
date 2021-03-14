using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameComponent : entIComponent
	{
		private CHandle<gamePersistentState> _persistentState;

		[Ordinal(3)] 
		[RED("persistentState")] 
		public CHandle<gamePersistentState> PersistentState
		{
			get
			{
				if (_persistentState == null)
				{
					_persistentState = (CHandle<gamePersistentState>) CR2WTypeManager.Create("handle:gamePersistentState", "persistentState", cr2w, this);
				}
				return _persistentState;
			}
			set
			{
				if (_persistentState == value)
				{
					return;
				}
				_persistentState = value;
				PropertySet(this);
			}
		}

		public gameComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
