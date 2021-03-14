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
			get
			{
				if (_dataTrackingFact == null)
				{
					_dataTrackingFact = (CEnum<ETelemetryData>) CR2WTypeManager.Create("ETelemetryData", "dataTrackingFact", cr2w, this);
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

		public ModifyTelemetryVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
