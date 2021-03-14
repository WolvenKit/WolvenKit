using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyNPCTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		private CEnum<ENPCTelemetryData> _dataTrackingFact;
		private CInt32 _value;

		[Ordinal(1)] 
		[RED("dataTrackingFact")] 
		public CEnum<ENPCTelemetryData> DataTrackingFact
		{
			get
			{
				if (_dataTrackingFact == null)
				{
					_dataTrackingFact = (CEnum<ENPCTelemetryData>) CR2WTypeManager.Create("ENPCTelemetryData", "dataTrackingFact", cr2w, this);
				}
				return _dataTrackingFact;
			}
			set
			{
				if (_dataTrackingFact == value)
				{
					return;
				}
				_dataTrackingFact = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public ModifyNPCTelemetryVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
