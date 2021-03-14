using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocketStamp : CVariable
	{
		private CUInt16 _name;
		private CUInt16 _ordinal;

		[Ordinal(0)] 
		[RED("name")] 
		public CUInt16 Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CUInt16) CR2WTypeManager.Create("Uint16", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ordinal")] 
		public CUInt16 Ordinal
		{
			get
			{
				if (_ordinal == null)
				{
					_ordinal = (CUInt16) CR2WTypeManager.Create("Uint16", "ordinal", cr2w, this);
				}
				return _ordinal;
			}
			set
			{
				if (_ordinal == value)
				{
					return;
				}
				_ordinal = value;
				PropertySet(this);
			}
		}

		public scnOutputSocketStamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
