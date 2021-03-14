using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningPulseStartEvent : redEvent
	{
		private CInt32 _targetsAffected;

		[Ordinal(0)] 
		[RED("targetsAffected")] 
		public CInt32 TargetsAffected
		{
			get
			{
				if (_targetsAffected == null)
				{
					_targetsAffected = (CInt32) CR2WTypeManager.Create("Int32", "targetsAffected", cr2w, this);
				}
				return _targetsAffected;
			}
			set
			{
				if (_targetsAffected == value)
				{
					return;
				}
				_targetsAffected = value;
				PropertySet(this);
			}
		}

		public gameScanningPulseStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
