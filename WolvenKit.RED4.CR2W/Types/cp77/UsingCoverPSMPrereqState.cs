using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UsingCoverPSMPrereqState : PlayerStateMachinePrereqState
	{
		private CBool _bValue;

		[Ordinal(3)] 
		[RED("bValue")] 
		public CBool BValue
		{
			get
			{
				if (_bValue == null)
				{
					_bValue = (CBool) CR2WTypeManager.Create("Bool", "bValue", cr2w, this);
				}
				return _bValue;
			}
			set
			{
				if (_bValue == value)
				{
					return;
				}
				_bValue = value;
				PropertySet(this);
			}
		}

		public UsingCoverPSMPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
