using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netPeerID : CVariable
	{
		private CUInt8 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt8 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CUInt8) CR2WTypeManager.Create("Uint8", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public netPeerID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
