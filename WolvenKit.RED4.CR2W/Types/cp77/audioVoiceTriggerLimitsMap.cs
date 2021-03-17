using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerLimitsMap : audioAudioMetadata
	{
		private CArray<CName> _includes;
		private CArray<audioVoiceTriggerLimitsMapItem> _triggers;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetProperty(ref _includes);
			set => SetProperty(ref _includes, value);
		}

		[Ordinal(2)] 
		[RED("triggers")] 
		public CArray<audioVoiceTriggerLimitsMapItem> Triggers
		{
			get => GetProperty(ref _triggers);
			set => SetProperty(ref _triggers, value);
		}

		public audioVoiceTriggerLimitsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
