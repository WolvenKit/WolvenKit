using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSignalId : CVariable
	{
		private CUInt16 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt16 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CUInt16) CR2WTypeManager.Create("Uint16", "value", cr2w, this);
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

		public gameSignalId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
