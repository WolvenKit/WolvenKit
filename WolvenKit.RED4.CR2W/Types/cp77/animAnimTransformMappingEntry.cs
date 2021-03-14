using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimTransformMappingEntry : CVariable
	{
		private CName _from;
		private CName _to;

		[Ordinal(0)] 
		[RED("from")] 
		public CName From
		{
			get
			{
				if (_from == null)
				{
					_from = (CName) CR2WTypeManager.Create("CName", "from", cr2w, this);
				}
				return _from;
			}
			set
			{
				if (_from == value)
				{
					return;
				}
				_from = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CName To
		{
			get
			{
				if (_to == null)
				{
					_to = (CName) CR2WTypeManager.Create("CName", "to", cr2w, this);
				}
				return _to;
			}
			set
			{
				if (_to == value)
				{
					return;
				}
				_to = value;
				PropertySet(this);
			}
		}

		public animAnimTransformMappingEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
