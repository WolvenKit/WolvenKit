using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerPerSquadOrderMapItem : CVariable
	{
		private CName _name;
		private CName _triggerName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetProperty(ref _triggerName);
			set => SetProperty(ref _triggerName, value);
		}

		public audioVoiceTriggerPerSquadOrderMapItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
