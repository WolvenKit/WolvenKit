using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHardcodedSignalPriorityDefinition : gameSignalPriorityDefinition
	{
		private CArray<CName> _signals;

		[Ordinal(1)] 
		[RED("signals")] 
		public CArray<CName> Signals
		{
			get
			{
				if (_signals == null)
				{
					_signals = (CArray<CName>) CR2WTypeManager.Create("array:CName", "signals", cr2w, this);
				}
				return _signals;
			}
			set
			{
				if (_signals == value)
				{
					return;
				}
				_signals = value;
				PropertySet(this);
			}
		}

		public gameHardcodedSignalPriorityDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
