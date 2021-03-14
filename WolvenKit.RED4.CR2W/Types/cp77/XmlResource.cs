using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class XmlResource : CResource
	{
		private CString _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CString Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CString) CR2WTypeManager.Create("String", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public XmlResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
