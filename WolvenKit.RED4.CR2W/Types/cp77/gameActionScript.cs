using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionScript : gameIObjectScriptBase
	{
		private CUInt32 _actionFlags;

		[Ordinal(1)] 
		[RED("actionFlags")] 
		public CUInt32 ActionFlags
		{
			get
			{
				if (_actionFlags == null)
				{
					_actionFlags = (CUInt32) CR2WTypeManager.Create("Uint32", "actionFlags", cr2w, this);
				}
				return _actionFlags;
			}
			set
			{
				if (_actionFlags == value)
				{
					return;
				}
				_actionFlags = value;
				PropertySet(this);
			}
		}

		public gameActionScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
