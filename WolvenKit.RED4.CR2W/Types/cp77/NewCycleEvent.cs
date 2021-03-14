using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewCycleEvent : redEvent
	{
		private CUInt16 _cyclesCount;

		[Ordinal(0)] 
		[RED("cyclesCount")] 
		public CUInt16 CyclesCount
		{
			get
			{
				if (_cyclesCount == null)
				{
					_cyclesCount = (CUInt16) CR2WTypeManager.Create("Uint16", "cyclesCount", cr2w, this);
				}
				return _cyclesCount;
			}
			set
			{
				if (_cyclesCount == value)
				{
					return;
				}
				_cyclesCount = value;
				PropertySet(this);
			}
		}

		public NewCycleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
