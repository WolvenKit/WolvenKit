using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopGraphConnectionCreationData : CVariable
	{
		private CString _data;
		private CArray<CString> _extraData;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("extraData")] 
		public CArray<CString> ExtraData
		{
			get
			{
				if (_extraData == null)
				{
					_extraData = (CArray<CString>) CR2WTypeManager.Create("array:String", "extraData", cr2w, this);
				}
				return _extraData;
			}
			set
			{
				if (_extraData == value)
				{
					return;
				}
				_extraData = value;
				PropertySet(this);
			}
		}

		public interopGraphConnectionCreationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
