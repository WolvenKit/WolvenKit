using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SHitFlag : CVariable
	{
		private CEnum<hitFlag> _flag;
		private CName _source;

		[Ordinal(0)] 
		[RED("flag")] 
		public CEnum<hitFlag> Flag
		{
			get
			{
				if (_flag == null)
				{
					_flag = (CEnum<hitFlag>) CR2WTypeManager.Create("hitFlag", "flag", cr2w, this);
				}
				return _flag;
			}
			set
			{
				if (_flag == value)
				{
					return;
				}
				_flag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		public SHitFlag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
