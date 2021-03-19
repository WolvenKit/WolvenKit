using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimEvent : scnPlayFPPControlAnimEvent
	{
		private CHandle<scnAnimName> _animName;
		private CHandle<scnEventBlendWorkspotSetupParameters> _poseBlendOutWorkspot;
		private scnPlaySkAnimRootMotionData _rootMotionData;
		private scnPlayerAnimData _playerData;

		[Ordinal(31)] 
		[RED("animName")] 
		public CHandle<scnAnimName> AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(32)] 
		[RED("poseBlendOutWorkspot")] 
		public CHandle<scnEventBlendWorkspotSetupParameters> PoseBlendOutWorkspot
		{
			get => GetProperty(ref _poseBlendOutWorkspot);
			set => SetProperty(ref _poseBlendOutWorkspot, value);
		}

		[Ordinal(33)] 
		[RED("rootMotionData")] 
		public scnPlaySkAnimRootMotionData RootMotionData
		{
			get => GetProperty(ref _rootMotionData);
			set => SetProperty(ref _rootMotionData, value);
		}

		[Ordinal(34)] 
		[RED("playerData")] 
		public scnPlayerAnimData PlayerData
		{
			get => GetProperty(ref _playerData);
			set => SetProperty(ref _playerData, value);
		}

		public scnPlaySkAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
