using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeActiveContextRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<inputContextType> _newContext;

		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<inputContextType> NewContext
		{
			get
			{
				if (_newContext == null)
				{
					_newContext = (CEnum<inputContextType>) CR2WTypeManager.Create("inputContextType", "newContext", cr2w, this);
				}
				return _newContext;
			}
			set
			{
				if (_newContext == value)
				{
					return;
				}
				_newContext = value;
				PropertySet(this);
			}
		}

		public ChangeActiveContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
