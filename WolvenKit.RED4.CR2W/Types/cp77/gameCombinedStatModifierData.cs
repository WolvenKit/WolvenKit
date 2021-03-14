using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCombinedStatModifierData : gameStatModifierData
	{
		private CEnum<gamedataStatType> _refStatType;
		private CEnum<gameCombinedStatOperation> _operation;
		private CEnum<gameStatObjectsRelation> _refObject;
		private CFloat _value;

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

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<gameCombinedStatOperation> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CEnum<gameCombinedStatOperation>) CR2WTypeManager.Create("gameCombinedStatOperation", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("refObject")] 
		public CEnum<gameStatObjectsRelation> RefObject
		{
			get
			{
				if (_refObject == null)
				{
					_refObject = (CEnum<gameStatObjectsRelation>) CR2WTypeManager.Create("gameStatObjectsRelation", "refObject", cr2w, this);
				}
				return _refObject;
			}
			set
			{
				if (_refObject == value)
				{
					return;
				}
				_refObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public gameCombinedStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
