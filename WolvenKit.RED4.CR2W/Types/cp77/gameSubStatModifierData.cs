using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSubStatModifierData : gameStatModifierData
	{
		private CEnum<gamedataStatType> _refStatType;

		[Ordinal(2)] 
		[RED("refStatType")] 
		public CEnum<gamedataStatType> RefStatType
		{
			get
			{
				if (_refStatType == null)
				{
					_refStatType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "refStatType", cr2w, this);
				}
				return _refStatType;
			}
			set
			{
				if (_refStatType == value)
				{
					return;
				}
				_refStatType = value;
				PropertySet(this);
			}
		}

		public gameSubStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
