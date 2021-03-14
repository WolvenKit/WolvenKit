using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SMeshTopology : CVariable
	{
		private DataBuffer _data;
		private DataBuffer _metadata;

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

		[Ordinal(1)] 
		[RED("metadata")] 
		public DataBuffer Metadata
		{
			get
			{
				if (_metadata == null)
				{
					_metadata = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "metadata", cr2w, this);
				}
				return _metadata;
			}
			set
			{
				if (_metadata == value)
				{
					return;
				}
				_metadata = value;
				PropertySet(this);
			}
		}

		public SMeshTopology(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
