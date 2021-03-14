using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpecialProperties : CVariable
	{
		private CBool _enemyMarker;
		private CArray<CEnum<ETrap>> _traps;

		[Ordinal(0)] 
		[RED("enemyMarker")] 
		public CBool EnemyMarker
		{
			get
			{
				if (_enemyMarker == null)
				{
					_enemyMarker = (CBool) CR2WTypeManager.Create("Bool", "enemyMarker", cr2w, this);
				}
				return _enemyMarker;
			}
			set
			{
				if (_enemyMarker == value)
				{
					return;
				}
				_enemyMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("traps")] 
		public CArray<CEnum<ETrap>> Traps
		{
			get
			{
				if (_traps == null)
				{
					_traps = (CArray<CEnum<ETrap>>) CR2WTypeManager.Create("array:ETrap", "traps", cr2w, this);
				}
				return _traps;
			}
			set
			{
				if (_traps == value)
				{
					return;
				}
				_traps = value;
				PropertySet(this);
			}
		}

		public SpecialProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
