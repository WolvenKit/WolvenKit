using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DeviceWorkspot : animAnimFeature
	{
		private CBool _e3_lockInReferencePose;

		[Ordinal(0)] 
		[RED("e3_lockInReferencePose")] 
		public CBool E3_lockInReferencePose
		{
			get => GetProperty(ref _e3_lockInReferencePose);
			set => SetProperty(ref _e3_lockInReferencePose, value);
		}

		public AnimFeature_DeviceWorkspot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
