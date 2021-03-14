using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ButtonPlaySoundView : BaseButtonView
	{
		private CName _soundPrefix;
		private CName _pressSoundName;
		private CName _hoverSoundName;

		[Ordinal(2)] 
		[RED("SoundPrefix")] 
		public CName SoundPrefix
		{
			get
			{
				if (_soundPrefix == null)
				{
					_soundPrefix = (CName) CR2WTypeManager.Create("CName", "SoundPrefix", cr2w, this);
				}
				return _soundPrefix;
			}
			set
			{
				if (_soundPrefix == value)
				{
					return;
				}
				_soundPrefix = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("PressSoundName")] 
		public CName PressSoundName
		{
			get
			{
				if (_pressSoundName == null)
				{
					_pressSoundName = (CName) CR2WTypeManager.Create("CName", "PressSoundName", cr2w, this);
				}
				return _pressSoundName;
			}
			set
			{
				if (_pressSoundName == value)
				{
					return;
				}
				_pressSoundName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("HoverSoundName")] 
		public CName HoverSoundName
		{
			get
			{
				if (_hoverSoundName == null)
				{
					_hoverSoundName = (CName) CR2WTypeManager.Create("CName", "HoverSoundName", cr2w, this);
				}
				return _hoverSoundName;
			}
			set
			{
				if (_hoverSoundName == value)
				{
					return;
				}
				_hoverSoundName = value;
				PropertySet(this);
			}
		}

		public ButtonPlaySoundView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
