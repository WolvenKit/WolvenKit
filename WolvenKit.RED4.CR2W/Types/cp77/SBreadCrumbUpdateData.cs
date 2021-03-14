using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBreadCrumbUpdateData : CVariable
	{
		private CString _elementName;
		private CInt32 _elementID;
		private CName _context;

		[Ordinal(0)] 
		[RED("elementName")] 
		public CString ElementName
		{
			get
			{
				if (_elementName == null)
				{
					_elementName = (CString) CR2WTypeManager.Create("String", "elementName", cr2w, this);
				}
				return _elementName;
			}
			set
			{
				if (_elementName == value)
				{
					return;
				}
				_elementName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("elementID")] 
		public CInt32 ElementID
		{
			get
			{
				if (_elementID == null)
				{
					_elementID = (CInt32) CR2WTypeManager.Create("Int32", "elementID", cr2w, this);
				}
				return _elementID;
			}
			set
			{
				if (_elementID == value)
				{
					return;
				}
				_elementID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("context")] 
		public CName Context
		{
			get
			{
				if (_context == null)
				{
					_context = (CName) CR2WTypeManager.Create("CName", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		public SBreadCrumbUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
