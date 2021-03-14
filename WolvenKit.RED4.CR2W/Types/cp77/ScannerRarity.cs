using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerRarity : ScannerChunk
	{
		private CEnum<gamedataNPCRarity> _rarity;
		private CBool _isCivilian;

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
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get
			{
				if (_isCivilian == null)
				{
					_isCivilian = (CBool) CR2WTypeManager.Create("Bool", "isCivilian", cr2w, this);
				}
				return _isCivilian;
			}
			set
			{
				if (_isCivilian == value)
				{
					return;
				}
				_isCivilian = value;
				PropertySet(this);
			}
		}

		public ScannerRarity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
