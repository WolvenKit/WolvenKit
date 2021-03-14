using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CallElevator : ActionBool
	{
		private CInt32 _destination;

		[Ordinal(25)] 
		[RED("destination")] 
		public CInt32 Destination
		{
			get
			{
				if (_destination == null)
				{
					_destination = (CInt32) CR2WTypeManager.Create("Int32", "destination", cr2w, this);
				}
				return _destination;
			}
			set
			{
				if (_destination == value)
				{
					return;
				}
				_destination = value;
				PropertySet(this);
			}
		}

		public CallElevator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
