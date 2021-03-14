using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_PlaySound : gameTransformAnimationTrackItemImpl
	{
		private CName _soundName;
		private CBool _unique;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get
			{
				if (_soundName == null)
				{
					_soundName = (CName) CR2WTypeManager.Create("CName", "soundName", cr2w, this);
				}
				return _soundName;
			}
			set
			{
				if (_soundName == value)
				{
					return;
				}
				_soundName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unique")] 
		public CBool Unique
		{
			get
			{
				if (_unique == null)
				{
					_unique = (CBool) CR2WTypeManager.Create("Bool", "unique", cr2w, this);
				}
				return _unique;
			}
			set
			{
				if (_unique == value)
				{
					return;
				}
				_unique = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_PlaySound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
