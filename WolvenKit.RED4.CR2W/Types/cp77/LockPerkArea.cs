using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LockPerkArea : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataPerkArea> _perkArea;

		[Ordinal(1)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get
			{
				if (_perkArea == null)
				{
					_perkArea = (CEnum<gamedataPerkArea>) CR2WTypeManager.Create("gamedataPerkArea", "perkArea", cr2w, this);
				}
				return _perkArea;
			}
			set
			{
				if (_perkArea == value)
				{
					return;
				}
				_perkArea = value;
				PropertySet(this);
			}
		}

		public LockPerkArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
