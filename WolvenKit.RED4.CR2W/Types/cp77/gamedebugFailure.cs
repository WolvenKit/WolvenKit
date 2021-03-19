using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedebugFailure : ISerializable
	{
		private gamedebugFailureId _id;
		private CFloat _time;
		private CString _message;
		private gameDebugPath _path;
		private CHandle<gamedebugFailure> _previous;
		private CHandle<gamedebugFailure> _cause;

		[Ordinal(0)] 
		[RED("id")] 
		public gamedebugFailureId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		[Ordinal(3)] 
		[RED("path")] 
		public gameDebugPath Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(4)] 
		[RED("previous")] 
		public CHandle<gamedebugFailure> Previous
		{
			get => GetProperty(ref _previous);
			set => SetProperty(ref _previous, value);
		}

		[Ordinal(5)] 
		[RED("cause")] 
		public CHandle<gamedebugFailure> Cause
		{
			get => GetProperty(ref _cause);
			set => SetProperty(ref _cause, value);
		}

		public gamedebugFailure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
