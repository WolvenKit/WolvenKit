using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerData : CVariable
	{
		private CName _name;
		private CUInt32 _variationIndex;
		private CUInt32 _variationNumber;
		private CEnum<locVoiceoverContext> _overridingVoContext;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("variationIndex")] 
		public CUInt32 VariationIndex
		{
			get
			{
				if (_variationIndex == null)
				{
					_variationIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "variationIndex", cr2w, this);
				}
				return _variationIndex;
			}
			set
			{
				if (_variationIndex == value)
				{
					return;
				}
				_variationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("variationNumber")] 
		public CUInt32 VariationNumber
		{
			get
			{
				if (_variationNumber == null)
				{
					_variationNumber = (CUInt32) CR2WTypeManager.Create("Uint32", "variationNumber", cr2w, this);
				}
				return _variationNumber;
			}
			set
			{
				if (_variationNumber == value)
				{
					return;
				}
				_variationNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("overridingVoContext")] 
		public CEnum<locVoiceoverContext> OverridingVoContext
		{
			get
			{
				if (_overridingVoContext == null)
				{
					_overridingVoContext = (CEnum<locVoiceoverContext>) CR2WTypeManager.Create("locVoiceoverContext", "overridingVoContext", cr2w, this);
				}
				return _overridingVoContext;
			}
			set
			{
				if (_overridingVoContext == value)
				{
					return;
				}
				_overridingVoContext = value;
				PropertySet(this);
			}
		}

		public audioVoiceTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
