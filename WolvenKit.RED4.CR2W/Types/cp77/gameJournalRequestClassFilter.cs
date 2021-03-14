using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestClassFilter : CVariable
	{
		private CName _className;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		public gameJournalRequestClassFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
