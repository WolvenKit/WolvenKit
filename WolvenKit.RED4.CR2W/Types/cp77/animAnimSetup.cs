using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetup : CVariable
	{
		private CArray<animAnimSetupEntry> _cinematics;
		private CArray<animAnimSetupEntry> _gameplay;

		[Ordinal(0)] 
		[RED("cinematics")] 
		public CArray<animAnimSetupEntry> Cinematics
		{
			get
			{
				if (_cinematics == null)
				{
					_cinematics = (CArray<animAnimSetupEntry>) CR2WTypeManager.Create("array:animAnimSetupEntry", "cinematics", cr2w, this);
				}
				return _cinematics;
			}
			set
			{
				if (_cinematics == value)
				{
					return;
				}
				_cinematics = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameplay")] 
		public CArray<animAnimSetupEntry> Gameplay
		{
			get
			{
				if (_gameplay == null)
				{
					_gameplay = (CArray<animAnimSetupEntry>) CR2WTypeManager.Create("array:animAnimSetupEntry", "gameplay", cr2w, this);
				}
				return _gameplay;
			}
			set
			{
				if (_gameplay == value)
				{
					return;
				}
				_gameplay = value;
				PropertySet(this);
			}
		}

		public animAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
