using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeHitSoundMetadata : audioAudioMetadata
	{
		private CHandle<audioMaterialMeleeSoundDictionary> _meleeSoundsByMaterial;

		[Ordinal(1)] 
		[RED("meleeSoundsByMaterial")] 
		public CHandle<audioMaterialMeleeSoundDictionary> MeleeSoundsByMaterial
		{
			get
			{
				if (_meleeSoundsByMaterial == null)
				{
					_meleeSoundsByMaterial = (CHandle<audioMaterialMeleeSoundDictionary>) CR2WTypeManager.Create("handle:audioMaterialMeleeSoundDictionary", "meleeSoundsByMaterial", cr2w, this);
				}
				return _meleeSoundsByMaterial;
			}
			set
			{
				if (_meleeSoundsByMaterial == value)
				{
					return;
				}
				_meleeSoundsByMaterial = value;
				PropertySet(this);
			}
		}

		public audioMeleeHitSoundMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
