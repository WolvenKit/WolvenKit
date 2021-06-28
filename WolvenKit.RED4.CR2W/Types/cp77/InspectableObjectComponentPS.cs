using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectableObjectComponentPS : gameComponentPS
	{
		private CBool _isStarted;
		private CBool _isFinished;
		private CArray<CHandle<questObjectInspectListener>> _listeners;

		[Ordinal(0)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get => GetProperty(ref _isStarted);
			set => SetProperty(ref _isStarted, value);
		}

		[Ordinal(1)] 
		[RED("isFinished")] 
		public CBool IsFinished
		{
			get => GetProperty(ref _isFinished);
			set => SetProperty(ref _isFinished, value);
		}

		[Ordinal(2)] 
		[RED("listeners")] 
		public CArray<CHandle<questObjectInspectListener>> Listeners
		{
			get => GetProperty(ref _listeners);
			set => SetProperty(ref _listeners, value);
		}

		public InspectableObjectComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
