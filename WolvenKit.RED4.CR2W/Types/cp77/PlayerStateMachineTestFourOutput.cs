using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachineTestFourOutput : IScriptable
	{
		private CInt32 _counter;

		[Ordinal(0)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get
			{
				if (_counter == null)
				{
					_counter = (CInt32) CR2WTypeManager.Create("Int32", "counter", cr2w, this);
				}
				return _counter;
			}
			set
			{
				if (_counter == value)
				{
					return;
				}
				_counter = value;
				PropertySet(this);
			}
		}

		public PlayerStateMachineTestFourOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
