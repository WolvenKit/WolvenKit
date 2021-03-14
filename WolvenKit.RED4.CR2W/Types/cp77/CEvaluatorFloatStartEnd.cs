using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorFloatStartEnd : IEvaluatorFloat
	{
		private CFloat _start;
		private CFloat _end;

		[Ordinal(0)] 
		[RED("start")] 
		public CFloat Start
		{
			get
			{
				if (_start == null)
				{
					_start = (CFloat) CR2WTypeManager.Create("Float", "start", cr2w, this);
				}
				return _start;
			}
			set
			{
				if (_start == value)
				{
					return;
				}
				_start = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CFloat End
		{
			get
			{
				if (_end == null)
				{
					_end = (CFloat) CR2WTypeManager.Create("Float", "end", cr2w, this);
				}
				return _end;
			}
			set
			{
				if (_end == value)
				{
					return;
				}
				_end = value;
				PropertySet(this);
			}
		}

		public CEvaluatorFloatStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
