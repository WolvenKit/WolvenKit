using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuildBluelinePart : gameinteractionsvisBluelinePart
	{
		private CHandle<gamedataPlayerBuild_Record> _record;
		private CInt32 _lhsValue;
		private CInt32 _rhsValue;
		private CEnum<ECompareOp> _comparisonOperator;

		[Ordinal(2)] 
		[RED("record")] 
		public CHandle<gamedataPlayerBuild_Record> Record
		{
			get
			{
				if (_record == null)
				{
					_record = (CHandle<gamedataPlayerBuild_Record>) CR2WTypeManager.Create("handle:gamedataPlayerBuild_Record", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lhsValue")] 
		public CInt32 LhsValue
		{
			get
			{
				if (_lhsValue == null)
				{
					_lhsValue = (CInt32) CR2WTypeManager.Create("Int32", "lhsValue", cr2w, this);
				}
				return _lhsValue;
			}
			set
			{
				if (_lhsValue == value)
				{
					return;
				}
				_lhsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rhsValue")] 
		public CInt32 RhsValue
		{
			get
			{
				if (_rhsValue == null)
				{
					_rhsValue = (CInt32) CR2WTypeManager.Create("Int32", "rhsValue", cr2w, this);
				}
				return _rhsValue;
			}
			set
			{
				if (_rhsValue == value)
				{
					return;
				}
				_rhsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("comparisonOperator")] 
		public CEnum<ECompareOp> ComparisonOperator
		{
			get
			{
				if (_comparisonOperator == null)
				{
					_comparisonOperator = (CEnum<ECompareOp>) CR2WTypeManager.Create("ECompareOp", "comparisonOperator", cr2w, this);
				}
				return _comparisonOperator;
			}
			set
			{
				if (_comparisonOperator == value)
				{
					return;
				}
				_comparisonOperator = value;
				PropertySet(this);
			}
		}

		public BuildBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
