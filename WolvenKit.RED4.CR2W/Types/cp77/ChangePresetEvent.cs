using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangePresetEvent : redEvent
	{
		private CEnum<ESmartHousePreset> _presetID;

		[Ordinal(0)] 
		[RED("presetID")] 
		public CEnum<ESmartHousePreset> PresetID
		{
			get
			{
				if (_presetID == null)
				{
					_presetID = (CEnum<ESmartHousePreset>) CR2WTypeManager.Create("ESmartHousePreset", "presetID", cr2w, this);
				}
				return _presetID;
			}
			set
			{
				if (_presetID == value)
				{
					return;
				}
				_presetID = value;
				PropertySet(this);
			}
		}

		public ChangePresetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
