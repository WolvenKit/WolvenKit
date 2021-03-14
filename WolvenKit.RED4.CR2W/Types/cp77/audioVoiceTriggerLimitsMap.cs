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
			get
			{
				if (_includes == null)
				{
					_includes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "includes", cr2w, this);
				}
				return _includes;
			}
			set
			{
				if (_includes == value)
				{
					return;
				}
				_includes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("triggers")] 
		public CArray<audioVoiceTriggerLimitsMapItem> Triggers
		{
			get
			{
				if (_triggers == null)
				{
					_triggers = (CArray<audioVoiceTriggerLimitsMapItem>) CR2WTypeManager.Create("array:audioVoiceTriggerLimitsMapItem", "triggers", cr2w, this);
				}
				return _triggers;
			}
			set
			{
				if (_triggers == value)
				{
					return;
				}
				_triggers = value;
				PropertySet(this);
			}
		}

		public audioVoiceTriggerLimitsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
