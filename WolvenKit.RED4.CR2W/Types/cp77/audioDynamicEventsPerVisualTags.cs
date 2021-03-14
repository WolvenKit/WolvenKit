using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDynamicEventsPerVisualTags : CVariable
	{
		private CArray<CName> _visualTags;
		private CArray<audioDynamicEventsWithInterval> _grunts;

		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get
			{
				if (_visualTags == null)
				{
					_visualTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "visualTags", cr2w, this);
				}
				return _visualTags;
			}
			set
			{
				if (_visualTags == value)
				{
					return;
				}
				_visualTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("grunts")] 
		public CArray<audioDynamicEventsWithInterval> Grunts
		{
			get
			{
				if (_grunts == null)
				{
					_grunts = (CArray<audioDynamicEventsWithInterval>) CR2WTypeManager.Create("array:audioDynamicEventsWithInterval", "grunts", cr2w, this);
				}
				return _grunts;
			}
			set
			{
				if (_grunts == value)
				{
					return;
				}
				_grunts = value;
				PropertySet(this);
			}
		}

		public audioDynamicEventsPerVisualTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
