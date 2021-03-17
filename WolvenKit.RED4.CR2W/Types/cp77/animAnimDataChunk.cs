using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimDataChunk : CVariable
	{
		private serializationDeferredDataBuffer _buffer;

		[Ordinal(0)] 
		[RED("buffer")] 
		public serializationDeferredDataBuffer Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}

		public animAnimDataChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
