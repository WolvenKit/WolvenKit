using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorStartEnd : IEvaluatorVector
	{
		private Vector4 _start;
		private Vector4 _end;

		[Ordinal(2)] 
		[RED("start")] 
		public Vector4 Start
		{
			get
			{
				if (_start == null)
				{
					_start = (Vector4) CR2WTypeManager.Create("Vector4", "start", cr2w, this);
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

		[Ordinal(3)] 
		[RED("end")] 
		public Vector4 End
		{
			get
			{
				if (_end == null)
				{
					_end = (Vector4) CR2WTypeManager.Create("Vector4", "end", cr2w, this);
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

		public CEvaluatorVectorStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
