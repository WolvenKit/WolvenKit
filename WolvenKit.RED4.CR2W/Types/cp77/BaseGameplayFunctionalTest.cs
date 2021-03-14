using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseGameplayFunctionalTest : IScriptable
	{
		private CFloat _maxExecutionTimeSec;
		private CFloat _executionTimeSec;

		[Ordinal(0)] 
		[RED("maxExecutionTimeSec")] 
		public CFloat MaxExecutionTimeSec
		{
			get
			{
				if (_maxExecutionTimeSec == null)
				{
					_maxExecutionTimeSec = (CFloat) CR2WTypeManager.Create("Float", "maxExecutionTimeSec", cr2w, this);
				}
				return _maxExecutionTimeSec;
			}
			set
			{
				if (_maxExecutionTimeSec == value)
				{
					return;
				}
				_maxExecutionTimeSec = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("executionTimeSec")] 
		public CFloat ExecutionTimeSec
		{
			get
			{
				if (_executionTimeSec == null)
				{
					_executionTimeSec = (CFloat) CR2WTypeManager.Create("Float", "executionTimeSec", cr2w, this);
				}
				return _executionTimeSec;
			}
			set
			{
				if (_executionTimeSec == value)
				{
					return;
				}
				_executionTimeSec = value;
				PropertySet(this);
			}
		}

		public BaseGameplayFunctionalTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
