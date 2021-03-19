using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsClueEvent : scnSceneEvent
	{
		private gameEntityReference _clueEntity;
		private CBool _markedOnTimeline;
		private CName _clueName;
		private CEnum<gameuiEBraindanceLayer> _layer;
		private CBool _overrideFact;
		private CName _factName;

		[Ordinal(6)] 
		[RED("clueEntity")] 
		public gameEntityReference ClueEntity
		{
			get => GetProperty(ref _clueEntity);
			set => SetProperty(ref _clueEntity, value);
		}

		[Ordinal(7)] 
		[RED("markedOnTimeline")] 
		public CBool MarkedOnTimeline
		{
			get => GetProperty(ref _markedOnTimeline);
			set => SetProperty(ref _markedOnTimeline, value);
		}

		[Ordinal(8)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get => GetProperty(ref _clueName);
			set => SetProperty(ref _clueName, value);
		}

		[Ordinal(9)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}

		[Ordinal(10)] 
		[RED("overrideFact")] 
		public CBool OverrideFact
		{
			get => GetProperty(ref _overrideFact);
			set => SetProperty(ref _overrideFact, value);
		}

		[Ordinal(11)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		public scneventsClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
