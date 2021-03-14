using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBreadcrumbElementData : CVariable
	{
		private CString _elementName;
		private CInt32 _elementID;

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

		public SBreadcrumbElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
