using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SInternetData : CVariable
	{
		private CString _startingPage;

		[Ordinal(0)] 
		[RED("startingPage")] 
		public CString StartingPage
		{
			get
			{
				if (_startingPage == null)
				{
					_startingPage = (CString) CR2WTypeManager.Create("String", "startingPage", cr2w, this);
				}
				return _startingPage;
			}
			set
			{
				if (_startingPage == value)
				{
					return;
				}
				_startingPage = value;
				PropertySet(this);
			}
		}

		public SInternetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
