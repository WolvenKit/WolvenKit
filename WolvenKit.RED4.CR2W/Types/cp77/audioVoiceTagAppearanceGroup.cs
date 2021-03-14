using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagAppearanceGroup : CVariable
	{
		private CArray<CName> _appearances;
		private CArray<CName> _voicetags;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<CName>) CR2WTypeManager.Create("array:CName", "appearances", cr2w, this);
				}
				return _appearances;
			}
			set
			{
				if (_appearances == value)
				{
					return;
				}
				_appearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voicetags")] 
		public CArray<CName> Voicetags
		{
			get
			{
				if (_voicetags == null)
				{
					_voicetags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "voicetags", cr2w, this);
				}
				return _voicetags;
			}
			set
			{
				if (_voicetags == value)
				{
					return;
				}
				_voicetags = value;
				PropertySet(this);
			}
		}

		public audioVoiceTagAppearanceGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
