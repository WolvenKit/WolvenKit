using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIISerializableArgumentInstancePS : AIArgumentInstancePS
	{
		private CHandle<ISerializable> _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<ISerializable> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CHandle<ISerializable>) CR2WTypeManager.Create("handle:ISerializable", "value", cr2w, this);
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

		public AIISerializableArgumentInstancePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
