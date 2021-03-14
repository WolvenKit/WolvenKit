using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectRef : CVariable
	{
		private rRef<gameEffectSet> _set;
		private CName _tag;

		[Ordinal(0)] 
		[RED("set")] 
		public rRef<gameEffectSet> Set
		{
			get
			{
				if (_set == null)
				{
					_set = (rRef<gameEffectSet>) CR2WTypeManager.Create("rRef:gameEffectSet", "set", cr2w, this);
				}
				return _set;
			}
			set
			{
				if (_set == value)
				{
					return;
				}
				_set = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		public gameEffectRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
