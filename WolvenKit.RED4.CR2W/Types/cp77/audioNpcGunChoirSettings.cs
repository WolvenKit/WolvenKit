using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioNpcGunChoirSettings : audioAudioMetadata
	{
		private CArray<CName> _voices;

		[Ordinal(1)] 
		[RED("voices")] 
		public CArray<CName> Voices
		{
			get
			{
				if (_voices == null)
				{
					_voices = (CArray<CName>) CR2WTypeManager.Create("array:CName", "voices", cr2w, this);
				}
				return _voices;
			}
			set
			{
				if (_voices == value)
				{
					return;
				}
				_voices = value;
				PropertySet(this);
			}
		}

		public audioNpcGunChoirSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
