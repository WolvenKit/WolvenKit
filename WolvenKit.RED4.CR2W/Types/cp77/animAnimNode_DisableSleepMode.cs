using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DisableSleepMode : animAnimNode_OnePoseInput
	{
		private CBool _forceUpdate;

		[Ordinal(12)] 
		[RED("forceUpdate")] 
		public CBool ForceUpdate
		{
			get => GetProperty(ref _forceUpdate);
			set => SetProperty(ref _forceUpdate, value);
		}

		public animAnimNode_DisableSleepMode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
