using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeEvent : CVariable
	{
		private CName _event;
		private CArray<audioAudSimpleParameter> _params;

		[Ordinal(0)] 
		[RED("event")] 
		public CName Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CArray<audioAudSimpleParameter> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public audioMeleeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
