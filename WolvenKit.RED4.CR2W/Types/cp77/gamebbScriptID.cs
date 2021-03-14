using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamebbScriptID : CVariable
	{
		private gamebbID _none;

		[Ordinal(0)] 
		[RED("None")] 
		public gamebbID None
		{
			get
			{
				if (_none == null)
				{
					_none = (gamebbID) CR2WTypeManager.Create("gamebbID", "None", cr2w, this);
				}
				return _none;
			}
			set
			{
				if (_none == value)
				{
					return;
				}
				_none = value;
				PropertySet(this);
			}
		}

		public gamebbScriptID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
