using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioSoundBankStruct : CVariable
	{
		private CName _soundBank;

		[Ordinal(0)] 
		[RED("soundBank")] 
		public CName SoundBank
		{
			get
			{
				if (_soundBank == null)
				{
					_soundBank = (CName) CR2WTypeManager.Create("CName", "soundBank", cr2w, this);
				}
				return _soundBank;
			}
			set
			{
				if (_soundBank == value)
				{
					return;
				}
				_soundBank = value;
				PropertySet(this);
			}
		}

		public audioSoundBankStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
