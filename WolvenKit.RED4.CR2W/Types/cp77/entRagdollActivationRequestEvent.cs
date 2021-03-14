using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollActivationRequestEvent : redEvent
	{
		private entragdollActivationRequestData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public entragdollActivationRequestData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (entragdollActivationRequestData) CR2WTypeManager.Create("entragdollActivationRequestData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public entRagdollActivationRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
