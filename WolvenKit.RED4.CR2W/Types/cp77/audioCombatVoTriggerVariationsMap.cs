using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoTriggerVariationsMap : audioAudioMetadata
	{
		private CArray<audioCombatVoTriggerVariationsMapItem> _voTriggerVariations;

		[Ordinal(1)] 
		[RED("voTriggerVariations")] 
		public CArray<audioCombatVoTriggerVariationsMapItem> VoTriggerVariations
		{
			get
			{
				if (_voTriggerVariations == null)
				{
					_voTriggerVariations = (CArray<audioCombatVoTriggerVariationsMapItem>) CR2WTypeManager.Create("array:audioCombatVoTriggerVariationsMapItem", "voTriggerVariations", cr2w, this);
				}
				return _voTriggerVariations;
			}
			set
			{
				if (_voTriggerVariations == value)
				{
					return;
				}
				_voTriggerVariations = value;
				PropertySet(this);
			}
		}

		public audioCombatVoTriggerVariationsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
