using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsDeferredCollection : ISerializable
	{
		private serializationDeferredDataBuffer _buffer;

		[Ordinal(0)] 
		[RED("buffer")] 
		public serializationDeferredDataBuffer Buffer
		{
			get
			{
				if (_buffer == null)
				{
					_buffer = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "buffer", cr2w, this);
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

		public physicsDeferredCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
