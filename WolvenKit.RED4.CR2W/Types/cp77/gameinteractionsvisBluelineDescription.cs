using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisBluelineDescription : IScriptable
	{
		private CArray<CHandle<gameinteractionsvisBluelinePart>> _parts;
		private CEnum<ELogicOperator> _logicOperator;

		[Ordinal(0)] 
		[RED("parts")] 
		public CArray<CHandle<gameinteractionsvisBluelinePart>> Parts
		{
			get
			{
				if (_parts == null)
				{
					_parts = (CArray<CHandle<gameinteractionsvisBluelinePart>>) CR2WTypeManager.Create("array:handle:gameinteractionsvisBluelinePart", "parts", cr2w, this);
				}
				return _parts;
			}
			set
			{
				if (_parts == value)
				{
					return;
				}
				_parts = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("logicOperator")] 
		public CEnum<ELogicOperator> LogicOperator
		{
			get
			{
				if (_logicOperator == null)
				{
					_logicOperator = (CEnum<ELogicOperator>) CR2WTypeManager.Create("ELogicOperator", "logicOperator", cr2w, this);
				}
				return _logicOperator;
			}
			set
			{
				if (_logicOperator == value)
				{
					return;
				}
				_logicOperator = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisBluelineDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
