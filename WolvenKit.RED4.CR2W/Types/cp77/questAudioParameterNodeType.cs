using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioParameterNodeType : questIAudioNodeType
	{
		private audioAudParameter _param;
		private CBool _isMusic;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;

		[Ordinal(0)] 
		[RED("param")] 
		public audioAudParameter Param
		{
			get => GetProperty(ref _param);
			set => SetProperty(ref _param, value);
		}

		[Ordinal(1)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetProperty(ref _isMusic);
			set => SetProperty(ref _isMusic, value);
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		public questAudioParameterNodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
