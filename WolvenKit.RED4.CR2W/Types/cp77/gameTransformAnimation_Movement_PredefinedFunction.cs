using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Movement_PredefinedFunction : gameTransformAnimation_Movement
	{
		private EasingFunction _function;

		[Ordinal(0)] 
		[RED("function")] 
		public EasingFunction Function
		{
			get
			{
				if (_function == null)
				{
					_function = (EasingFunction) CR2WTypeManager.Create("EasingFunction", "function", cr2w, this);
				}
				return _function;
			}
			set
			{
				if (_function == value)
				{
					return;
				}
				_function = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_Movement_PredefinedFunction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
