using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SlashEffect_Entry : CVariable
	{
		private CInt32 _attackNumber;
		private CArray<CName> _effectNames;

		[Ordinal(0)] 
		[RED("attackNumber")] 
		public CInt32 AttackNumber
		{
			get
			{
				if (_attackNumber == null)
				{
					_attackNumber = (CInt32) CR2WTypeManager.Create("Int32", "attackNumber", cr2w, this);
				}
				return _attackNumber;
			}
			set
			{
				if (_attackNumber == value)
				{
					return;
				}
				_attackNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectNames")] 
		public CArray<CName> EffectNames
		{
			get
			{
				if (_effectNames == null)
				{
					_effectNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "effectNames", cr2w, this);
				}
				return _effectNames;
			}
			set
			{
				if (_effectNames == value)
				{
					return;
				}
				_effectNames = value;
				PropertySet(this);
			}
		}

		public EffectExecutor_SlashEffect_Entry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
