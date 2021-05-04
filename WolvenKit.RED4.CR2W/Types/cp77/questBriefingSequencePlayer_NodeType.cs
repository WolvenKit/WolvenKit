using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBriefingSequencePlayer_NodeType : questIUIManagerNodeType
	{
		private CEnum<questBriefingSequencePlayerFunction> _function;
		private raRef<inkWidgetLibraryResource> _briefingResource;
		private CHandle<inkUserData> _userData;
		private CName _audioEvent;
		private CName _animationName;
		private CName _startMarkerName;
		private CName _endMarkerName;
		private CEnum<inkanimLoopType> _loopType;
		private CEnum<questBriefingType> _briefingType;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questBriefingSequencePlayerFunction> Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		[Ordinal(1)] 
		[RED("briefingResource")] 
		public raRef<inkWidgetLibraryResource> BriefingResource
		{
			get => GetProperty(ref _briefingResource);
			set => SetProperty(ref _briefingResource, value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<inkUserData> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(3)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(4)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(5)] 
		[RED("startMarkerName")] 
		public CName StartMarkerName
		{
			get => GetProperty(ref _startMarkerName);
			set => SetProperty(ref _startMarkerName, value);
		}

		[Ordinal(6)] 
		[RED("endMarkerName")] 
		public CName EndMarkerName
		{
			get => GetProperty(ref _endMarkerName);
			set => SetProperty(ref _endMarkerName, value);
		}

		[Ordinal(7)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get => GetProperty(ref _loopType);
			set => SetProperty(ref _loopType, value);
		}

		[Ordinal(8)] 
		[RED("briefingType")] 
		public CEnum<questBriefingType> BriefingType
		{
			get => GetProperty(ref _briefingType);
			set => SetProperty(ref _briefingType, value);
		}

		public questBriefingSequencePlayer_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
