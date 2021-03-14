using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTagMask : CVariable
	{
		private redTagList _hardTags;
		private redTagList _softTags;
		private redTagList _excludedTags;

		[Ordinal(0)] 
		[RED("hardTags")] 
		public redTagList HardTags
		{
			get
			{
				if (_hardTags == null)
				{
					_hardTags = (redTagList) CR2WTypeManager.Create("redTagList", "hardTags", cr2w, this);
				}
				return _hardTags;
			}
			set
			{
				if (_hardTags == value)
				{
					return;
				}
				_hardTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("softTags")] 
		public redTagList SoftTags
		{
			get
			{
				if (_softTags == null)
				{
					_softTags = (redTagList) CR2WTypeManager.Create("redTagList", "softTags", cr2w, this);
				}
				return _softTags;
			}
			set
			{
				if (_softTags == value)
				{
					return;
				}
				_softTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("excludedTags")] 
		public redTagList ExcludedTags
		{
			get
			{
				if (_excludedTags == null)
				{
					_excludedTags = (redTagList) CR2WTypeManager.Create("redTagList", "excludedTags", cr2w, this);
				}
				return _excludedTags;
			}
			set
			{
				if (_excludedTags == value)
				{
					return;
				}
				_excludedTags = value;
				PropertySet(this);
			}
		}

		public entTagMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
