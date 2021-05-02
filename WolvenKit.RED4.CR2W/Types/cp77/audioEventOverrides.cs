using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEventOverrides : audioAudioMetadata
	{
		private CHandle<audioEventOverrideDictionary> _eventOverrides;

		[Ordinal(1)] 
		[RED("eventOverrides")] 
		public CHandle<audioEventOverrideDictionary> EventOverrides
		{
			get => GetProperty(ref _eventOverrides);
			set => SetProperty(ref _eventOverrides, value);
		}

		public audioEventOverrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
