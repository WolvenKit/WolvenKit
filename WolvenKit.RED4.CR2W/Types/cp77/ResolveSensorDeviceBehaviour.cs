using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResolveSensorDeviceBehaviour : redEvent
	{
		private CInt32 _iteration;

		[Ordinal(0)] 
		[RED("iteration")] 
		public CInt32 Iteration
		{
			get
			{
				if (_iteration == null)
				{
					_iteration = (CInt32) CR2WTypeManager.Create("Int32", "iteration", cr2w, this);
				}
				return _iteration;
			}
			set
			{
				if (_iteration == value)
				{
					return;
				}
				_iteration = value;
				PropertySet(this);
			}
		}

		public ResolveSensorDeviceBehaviour(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
