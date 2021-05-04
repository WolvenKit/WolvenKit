using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDamageSystem : gameIDamageSystem
	{
		private previewTargetStruct _previewTarget;
		private CBool _previewLock;
		private ScriptReentrantRWLock _previewRWLockTemp;

		[Ordinal(0)] 
		[RED("previewTarget")] 
		public previewTargetStruct PreviewTarget
		{
			get => GetProperty(ref _previewTarget);
			set => SetProperty(ref _previewTarget, value);
		}

		[Ordinal(1)] 
		[RED("previewLock")] 
		public CBool PreviewLock
		{
			get => GetProperty(ref _previewLock);
			set => SetProperty(ref _previewLock, value);
		}

		[Ordinal(2)] 
		[RED("previewRWLockTemp")] 
		public ScriptReentrantRWLock PreviewRWLockTemp
		{
			get => GetProperty(ref _previewRWLockTemp);
			set => SetProperty(ref _previewRWLockTemp, value);
		}

		public gameDamageSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
