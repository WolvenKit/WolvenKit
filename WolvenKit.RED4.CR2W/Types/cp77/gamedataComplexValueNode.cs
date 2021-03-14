using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataComplexValueNode : gamedataValueDataNode
	{
		private CArray<CString> _data;

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<CString> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CString>) CR2WTypeManager.Create("array:String", "data", cr2w, this);
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

		public gamedataComplexValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
