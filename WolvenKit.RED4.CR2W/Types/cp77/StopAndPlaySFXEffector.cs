using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopAndPlaySFXEffector : gameEffector
	{
		private CName _sfxToStop;
		private CName _sfxToStart;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("sfxToStop")] 
		public CName SfxToStop
		{
			get
			{
				if (_sfxToStop == null)
				{
					_sfxToStop = (CName) CR2WTypeManager.Create("CName", "sfxToStop", cr2w, this);
				}
				return _sfxToStop;
			}
			set
			{
				if (_sfxToStop == value)
				{
					return;
				}
				_sfxToStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sfxToStart")] 
		public CName SfxToStart
		{
			get
			{
				if (_sfxToStart == null)
				{
					_sfxToStart = (CName) CR2WTypeManager.Create("CName", "sfxToStart", cr2w, this);
				}
				return _sfxToStart;
			}
			set
			{
				if (_sfxToStart == value)
				{
					return;
				}
				_sfxToStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public StopAndPlaySFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
