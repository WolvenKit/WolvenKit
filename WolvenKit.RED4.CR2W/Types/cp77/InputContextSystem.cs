using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputContextSystem : gameScriptableSystem
	{
		private CEnum<inputContextType> _activeContext;

		[Ordinal(0)] 
		[RED("activeContext")] 
		public CEnum<inputContextType> ActiveContext
		{
			get
			{
				if (_activeContext == null)
				{
					_activeContext = (CEnum<inputContextType>) CR2WTypeManager.Create("inputContextType", "activeContext", cr2w, this);
				}
				return _activeContext;
			}
			set
			{
				if (_activeContext == value)
				{
					return;
				}
				_activeContext = value;
				PropertySet(this);
			}
		}

		public InputContextSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
