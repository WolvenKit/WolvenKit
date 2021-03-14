using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceGenericDataContent : CVariable
	{
		private CString _name;
		private CArray<gamedeviceDataElement> _content;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("content")] 
		public CArray<gamedeviceDataElement> Content
		{
			get
			{
				if (_content == null)
				{
					_content = (CArray<gamedeviceDataElement>) CR2WTypeManager.Create("array:gamedeviceDataElement", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		public gamedeviceGenericDataContent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
