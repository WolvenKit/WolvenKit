using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBinkVideoData : ISerializable
	{
		private CArray<gameBinkVideoRecord> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<gameBinkVideoRecord> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<gameBinkVideoRecord>) CR2WTypeManager.Create("array:gameBinkVideoRecord", "data", cr2w, this);
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

		public gameBinkVideoData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
