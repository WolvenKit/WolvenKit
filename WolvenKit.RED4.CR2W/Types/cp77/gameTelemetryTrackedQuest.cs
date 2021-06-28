using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryTrackedQuest : CVariable
	{
		private CString _name;
		private CString _objectiveName;
		private CString _type;
		private CFloat _distance;
		private CString _questName;
		private CString _questType;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("objectiveName")] 
		public CString ObjectiveName
		{
			get => GetProperty(ref _objectiveName);
			set => SetProperty(ref _objectiveName, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CString Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(4)] 
		[RED("questName")] 
		public CString QuestName
		{
			get => GetProperty(ref _questName);
			set => SetProperty(ref _questName, value);
		}

		[Ordinal(5)] 
		[RED("questType")] 
		public CString QuestType
		{
			get => GetProperty(ref _questType);
			set => SetProperty(ref _questType, value);
		}

		public gameTelemetryTrackedQuest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
