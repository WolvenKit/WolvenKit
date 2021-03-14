using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorStartEnd : IEvaluatorColor
	{
		private CColor _start;
		private CColor _end;

		[Ordinal(0)] 
		[RED("start")] 
		public CColor Start
		{
			get
			{
				if (_start == null)
				{
					_start = (CColor) CR2WTypeManager.Create("Color", "start", cr2w, this);
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
		public CColor End
		{
			get
			{
				if (_end == null)
				{
					_end = (CColor) CR2WTypeManager.Create("Color", "end", cr2w, this);
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

		public CEvaluatorColorStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
