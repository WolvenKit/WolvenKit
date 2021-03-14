using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TagLinkedCluekRequest : gameScriptableSystemRequest
	{
		private CBool _tag;
		private LinkedFocusClueData _linkedCluekData;

		[Ordinal(0)] 
		[RED("tag")] 
		public CBool Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CBool) CR2WTypeManager.Create("Bool", "tag", cr2w, this);
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

		[Ordinal(1)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get
			{
				if (_linkedCluekData == null)
				{
					_linkedCluekData = (LinkedFocusClueData) CR2WTypeManager.Create("LinkedFocusClueData", "linkedCluekData", cr2w, this);
				}
				return _linkedCluekData;
			}
			set
			{
				if (_linkedCluekData == value)
				{
					return;
				}
				_linkedCluekData = value;
				PropertySet(this);
			}
		}

		public TagLinkedCluekRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
