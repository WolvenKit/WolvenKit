using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerLimitsMapItem : CVariable
	{
		private CName _name;
		private audioVoiceTriggerLimits _limits;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("limits")] 
		public audioVoiceTriggerLimits Limits
		{
			get => GetProperty(ref _limits);
			set => SetProperty(ref _limits, value);
		}

		public audioVoiceTriggerLimitsMapItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
