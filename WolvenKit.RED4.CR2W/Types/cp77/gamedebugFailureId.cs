using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedebugFailureId : CVariable
	{
		private CUInt32 _threadId;
		private CUInt32 _unsignedId;

		[Ordinal(0)] 
		[RED("threadId")] 
		public CUInt32 ThreadId
		{
			get => GetProperty(ref _threadId);
			set => SetProperty(ref _threadId, value);
		}

		[Ordinal(1)] 
		[RED("unsignedId")] 
		public CUInt32 UnsignedId
		{
			get => GetProperty(ref _unsignedId);
			set => SetProperty(ref _unsignedId, value);
		}

		public gamedebugFailureId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
