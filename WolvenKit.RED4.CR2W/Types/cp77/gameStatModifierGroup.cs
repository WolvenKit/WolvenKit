using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierGroup : CVariable
	{
		private CArray<CHandle<gameStatModifierData>> _statModifierArray;
		private CInt32 _statModifiersLimit;
		private TweakDBID _statModifiersLimitModifier;
		private CBool _drawBasedOnStatType;

		[Ordinal(0)] 
		[RED("statModifierArray")] 
		public CArray<CHandle<gameStatModifierData>> StatModifierArray
		{
			get
			{
				if (_statModifierArray == null)
				{
					_statModifierArray = (CArray<CHandle<gameStatModifierData>>) CR2WTypeManager.Create("array:handle:gameStatModifierData", "statModifierArray", cr2w, this);
				}
				return _statModifierArray;
			}
			set
			{
				if (_statModifierArray == value)
				{
					return;
				}
				_statModifierArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("statModifiersLimit")] 
		public CInt32 StatModifiersLimit
		{
			get
			{
				if (_statModifiersLimit == null)
				{
					_statModifiersLimit = (CInt32) CR2WTypeManager.Create("Int32", "statModifiersLimit", cr2w, this);
				}
				return _statModifiersLimit;
			}
			set
			{
				if (_statModifiersLimit == value)
				{
					return;
				}
				_statModifiersLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statModifiersLimitModifier")] 
		public TweakDBID StatModifiersLimitModifier
		{
			get
			{
				if (_statModifiersLimitModifier == null)
				{
					_statModifiersLimitModifier = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statModifiersLimitModifier", cr2w, this);
				}
				return _statModifiersLimitModifier;
			}
			set
			{
				if (_statModifiersLimitModifier == value)
				{
					return;
				}
				_statModifiersLimitModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("drawBasedOnStatType")] 
		public CBool DrawBasedOnStatType
		{
			get
			{
				if (_drawBasedOnStatType == null)
				{
					_drawBasedOnStatType = (CBool) CR2WTypeManager.Create("Bool", "drawBasedOnStatType", cr2w, this);
				}
				return _drawBasedOnStatType;
			}
			set
			{
				if (_drawBasedOnStatType == value)
				{
					return;
				}
				_drawBasedOnStatType = value;
				PropertySet(this);
			}
		}

		public gameStatModifierGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
