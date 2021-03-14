using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SMeshStream : CVariable
	{
		private serializationDeferredDataBuffer _data;
		private CEnum<EMeshStreamType> _type;

		[Ordinal(0)] 
		[RED("data")] 
		public serializationDeferredDataBuffer Data
		{
			get
			{
				if (_data == null)
				{
					_data = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "data", cr2w, this);
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
		[RED("type")] 
		public CEnum<EMeshStreamType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<EMeshStreamType>) CR2WTypeManager.Create("EMeshStreamType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public SMeshStream(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
