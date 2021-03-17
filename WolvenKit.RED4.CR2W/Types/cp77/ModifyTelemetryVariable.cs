using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		private CEnum<ETelemetryData> _dataTrackingFact;
		private CInt32 _value;

		[Ordinal(1)] 
		[RED("dataTrackingFact")] 
		public CEnum<ETelemetryData> DataTrackingFact
		{
			get => GetProperty(ref _dataTrackingFact);
			set => SetProperty(ref _dataTrackingFact, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public ModifyTelemetryVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
