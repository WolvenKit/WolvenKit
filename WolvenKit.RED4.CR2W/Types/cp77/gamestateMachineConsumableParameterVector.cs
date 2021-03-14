using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineConsumableParameterVector : gamestateMachineActionParameterVector
	{
		private CBool _consumed;

		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get
			{
				if (_consumed == null)
				{
					_consumed = (CBool) CR2WTypeManager.Create("Bool", "consumed", cr2w, this);
				}
				return _consumed;
			}
			set
			{
				if (_consumed == value)
				{
					return;
				}
				_consumed = value;
				PropertySet(this);
			}
		}

		public gamestateMachineConsumableParameterVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
