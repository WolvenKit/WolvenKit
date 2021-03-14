using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PresetAction : ActionBool
	{
		private CHandle<SmartHousePreset> _preset;

		[Ordinal(25)] 
		[RED("preset")] 
		public CHandle<SmartHousePreset> Preset
		{
			get
			{
				if (_preset == null)
				{
					_preset = (CHandle<SmartHousePreset>) CR2WTypeManager.Create("handle:SmartHousePreset", "preset", cr2w, this);
				}
				return _preset;
			}
			set
			{
				if (_preset == value)
				{
					return;
				}
				_preset = value;
				PropertySet(this);
			}
		}

		public PresetAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
