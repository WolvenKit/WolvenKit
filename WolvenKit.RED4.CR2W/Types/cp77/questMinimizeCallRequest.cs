using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMinimizeCallRequest : gameScriptableSystemRequest
	{
		private CBool _minimized;

		[Ordinal(0)] 
		[RED("minimized")] 
		public CBool Minimized
		{
			get
			{
				if (_minimized == null)
				{
					_minimized = (CBool) CR2WTypeManager.Create("Bool", "minimized", cr2w, this);
				}
				return _minimized;
			}
			set
			{
				if (_minimized == value)
				{
					return;
				}
				_minimized = value;
				PropertySet(this);
			}
		}

		public questMinimizeCallRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
