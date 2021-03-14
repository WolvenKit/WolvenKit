using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCRecordHasVisualTag : gameIScriptablePrereq
	{
		private CName _visualTag;
		private CBool _hasTag;

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

		[Ordinal(1)] 
		[RED("hasTag")] 
		public CBool HasTag
		{
			get
			{
				if (_hasTag == null)
				{
					_hasTag = (CBool) CR2WTypeManager.Create("Bool", "hasTag", cr2w, this);
				}
				return _hasTag;
			}
			set
			{
				if (_hasTag == value)
				{
					return;
				}
				_hasTag = value;
				PropertySet(this);
			}
		}

		public NPCRecordHasVisualTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
