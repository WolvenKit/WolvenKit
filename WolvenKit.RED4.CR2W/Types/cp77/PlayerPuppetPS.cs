using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppetPS : ScriptedPuppetPS
	{
		private KeyBindings _keybindigs;
		private CArray<gameuiMinigameProgramData> _availablePrograms;
		private CBool _hasAutoReveal;
		private CHandle<gameIBlackboard> _minigameBB;

		[Ordinal(26)] 
		[RED("keybindigs")] 
		public KeyBindings Keybindigs
		{
			get
			{
				if (_keybindigs == null)
				{
					_keybindigs = (KeyBindings) CR2WTypeManager.Create("KeyBindings", "keybindigs", cr2w, this);
				}
				return _keybindigs;
			}
			set
			{
				if (_keybindigs == value)
				{
					return;
				}
				_keybindigs = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("availablePrograms")] 
		public CArray<gameuiMinigameProgramData> AvailablePrograms
		{
			get
			{
				if (_availablePrograms == null)
				{
					_availablePrograms = (CArray<gameuiMinigameProgramData>) CR2WTypeManager.Create("array:gameuiMinigameProgramData", "availablePrograms", cr2w, this);
				}
				return _availablePrograms;
			}
			set
			{
				if (_availablePrograms == value)
				{
					return;
				}
				_availablePrograms = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get
			{
				if (_hasAutoReveal == null)
				{
					_hasAutoReveal = (CBool) CR2WTypeManager.Create("Bool", "hasAutoReveal", cr2w, this);
				}
				return _hasAutoReveal;
			}
			set
			{
				if (_hasAutoReveal == value)
				{
					return;
				}
				_hasAutoReveal = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("minigameBB")] 
		public CHandle<gameIBlackboard> MinigameBB
		{
			get
			{
				if (_minigameBB == null)
				{
					_minigameBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "minigameBB", cr2w, this);
				}
				return _minigameBB;
			}
			set
			{
				if (_minigameBB == value)
				{
					return;
				}
				_minigameBB = value;
				PropertySet(this);
			}
		}

		public PlayerPuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
