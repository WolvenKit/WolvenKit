using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsLookAtPredicate : gameinteractionsIPredicateType
	{
		private CEnum<gameinteractionsELookAtTarget> _testTarget;
		private CEnum<gameinteractionsELookAtTest> _testType;
		private CBool _stopOnTransparent;

		[Ordinal(0)] 
		[RED("testTarget")] 
		public CEnum<gameinteractionsELookAtTarget> TestTarget
		{
			get
			{
				if (_testTarget == null)
				{
					_testTarget = (CEnum<gameinteractionsELookAtTarget>) CR2WTypeManager.Create("gameinteractionsELookAtTarget", "testTarget", cr2w, this);
				}
				return _testTarget;
			}
			set
			{
				if (_testTarget == value)
				{
					return;
				}
				_testTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("testType")] 
		public CEnum<gameinteractionsELookAtTest> TestType
		{
			get
			{
				if (_testType == null)
				{
					_testType = (CEnum<gameinteractionsELookAtTest>) CR2WTypeManager.Create("gameinteractionsELookAtTest", "testType", cr2w, this);
				}
				return _testType;
			}
			set
			{
				if (_testType == value)
				{
					return;
				}
				_testType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get
			{
				if (_stopOnTransparent == null)
				{
					_stopOnTransparent = (CBool) CR2WTypeManager.Create("Bool", "stopOnTransparent", cr2w, this);
				}
				return _stopOnTransparent;
			}
			set
			{
				if (_stopOnTransparent == value)
				{
					return;
				}
				_stopOnTransparent = value;
				PropertySet(this);
			}
		}

		public gameinteractionsLookAtPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
