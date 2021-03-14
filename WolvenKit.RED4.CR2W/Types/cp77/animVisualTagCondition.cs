using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animVisualTagCondition : animIStaticCondition
	{
		private CName _visualTag;

		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get
			{
				if (_visualTag == null)
				{
					_visualTag = (CName) CR2WTypeManager.Create("CName", "visualTag", cr2w, this);
				}
				return _visualTag;
			}
			set
			{
				if (_visualTag == value)
				{
					return;
				}
				_visualTag = value;
				PropertySet(this);
			}
		}

		public animVisualTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
