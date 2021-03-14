using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCRarityPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataNPCRarity> _rarity;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get
			{
				if (_rarity == null)
				{
					_rarity = (CEnum<gamedataNPCRarity>) CR2WTypeManager.Create("gamedataNPCRarity", "rarity", cr2w, this);
				}
				return _rarity;
			}
			set
			{
				if (_rarity == value)
				{
					return;
				}
				_rarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public NPCRarityPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
