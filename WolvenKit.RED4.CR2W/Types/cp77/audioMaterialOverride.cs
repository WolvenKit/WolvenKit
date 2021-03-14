using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMaterialOverride : CVariable
	{
		private CName _base;
		private CName _override;

		[Ordinal(0)] 
		[RED("base")] 
		public CName Base
		{
			get
			{
				if (_base == null)
				{
					_base = (CName) CR2WTypeManager.Create("CName", "base", cr2w, this);
				}
				return _base;
			}
			set
			{
				if (_base == value)
				{
					return;
				}
				_base = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("override")] 
		public CName Override
		{
			get
			{
				if (_override == null)
				{
					_override = (CName) CR2WTypeManager.Create("CName", "override", cr2w, this);
				}
				return _override;
			}
			set
			{
				if (_override == value)
				{
					return;
				}
				_override = value;
				PropertySet(this);
			}
		}

		public audioMaterialOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
