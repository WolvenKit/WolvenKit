using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redConvexHullEx : CVariable
	{
		private DataBuffer _data;

		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get
			{
				if (_data == null)
				{
					_data = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "data", cr2w, this);
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

		public redConvexHullEx(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
