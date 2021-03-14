using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePersistentStateDataResource : CResource
	{
		private DataBuffer _buffer;

		[Ordinal(1)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get
			{
				if (_buffer == null)
				{
					_buffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "buffer", cr2w, this);
				}
				return _buffer;
			}
			set
			{
				if (_buffer == value)
				{
					return;
				}
				_buffer = value;
				PropertySet(this);
			}
		}

		public gamePersistentStateDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
